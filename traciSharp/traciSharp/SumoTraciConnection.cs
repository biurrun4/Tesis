using sumo.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

namespace traciSharp
{
    public class SumoTraciConnection
    {
        private bool withGui;
        private String configFile;
        private int randomSeed;
        private int remotePort;
        private Socket socket;
        //private String net_file;
        //private String route_file;
        private String sumoEXE = "sumo";//"/opt/sumo/sumo-0.15.0/bin/sumo";
        private CommandProcessor cp;
        private static readonly int CONNECT_RETRIES = 3;
        private CloseQuery closeQuery;
        private List<String> args = new List<String>();
        private String sumoArgs;
        private bool remote = false;
        private Process sumoProcess;
        private int steplength;
        private NetworkStream ns;
        private BinaryReader binRe;
        private BinaryWriter binWr;


        //public SumoTraciConnection(String paramString1, String paramString2, String paramString3)
        //{
        //    this.sumoEXE = paramString1;
        //    this.net_file = paramString2;
        //    this.route_file = paramString3;
        //}

        //public SumoTraciConnection(String paramString1, String paramString2)
        //{
        //    this.sumoEXE = paramString1;
        //    this.configFile = paramString2;
        //}

        public SumoTraciConnection(String configFile, int seed, bool withGui, int steplength)
        {
            this.randomSeed = seed;
            this.configFile = configFile;
            this.withGui = withGui;
            this.steplength = steplength;
        }

        //public SumoTraciConnection(SocketAddress paramSocketAddress)

        //{
        //    this.remote = true;
        //    this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    this.socket.NoDelay = true;
        //    int i = 500;
        //    int j = 0;
        //    while (j < 3)
        //    {
        //        try
        //        {
        //            this.socket.Connect(paramSocketAddress);
        //        }
        //        catch (Exception localConnectException)
        //        {
        //            Thread.Sleep(i);
        //            i *= 2;
        //            j++;
        //        }
        //    }
        //    if (!this.socket.Connected)
        //    {
        //        throw new IOException("can't connect to SUMO server");
        //    }
        //    this.cp = new CommandProcessor(this.socket);
        //}

        public void addOption(String option, String value)
        {

            if (paramString2 != null)
            {
                this.args.Add("--" + option);
                this.args.Add(value);
            }
        }
        public void addStepLength()
        {
            this.args.Add("--step-length");
            //Console.WriteLine(steplength);
            //Console.WriteLine("double: "+ (double)(steplength / 1000));
            this.args.Add(String.Format(new CultureInfo("en-EN"), "{0:0.000}", (double)steplength / 1000));
        }

        public void runServer()

        {
            if (!this.remote)
            {
                findAvailablePort();
                runSUMO();
                int i = 500;
                try
                {
                    int j = 0;
                    while (j < CONNECT_RETRIES)
                    {
                        this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        this.socket.NoDelay = true;
                        try
                        {
                            this.socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), this.remotePort));
                        }
                        catch (Exception localConnectException)
                        {
                            Console.WriteLine(localConnectException.StackTrace.ToString());
                            Thread.Sleep(i);
                            i *= 2;
                            j++;
                        }
                        if (!SocketConnected(socket))
                        {
                            if (j == 3) throw new IOException("can't connect to SUMO server");
                        }
                        else {
                            break;
                        }
                    }

                    this.cp = new CommandProcessor(socket);
                    ns = new NetworkStream(socket);
                    binRe = new BinaryReader(ns);
                    binWr = new BinaryWriter(ns);
                }
                catch (ThreadInterruptedException localInterruptedException)
                {
                    //Debug.Log(localInterruptedException.StackTrace.ToString());
                }
                this.closeQuery = new CloseQuery(this.socket);
            }
        }

        private void runSUMO()

        {

            if (withGui)
            {
                sumoEXE += "-gui";
            }

            String sumoEXE64 = sumoEXE;
            //bool is64bit = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
            //if (is64bit)
            //{
            //    sumoEXE64 += "64";
            //}
            if (this.configFile != null)
            {
                this.args.Add("-c");
                this.args.Add(this.configFile);
            }
            //else
            //{
            //    this.args.Add("--net-file");
            //    this.args.Add(this.net_file);
            //    this.args.Add("--route-files");
            //    this.args.Add(this.route_file);
            //}
            this.args.Add("--remote-port");
            this.args.Add(this.remotePort.ToString());
            addStepLength();
            //this.args.Add("--step-length");
            //this.args.Add(this.steplength.ToString());
            //args.Add("--step-length");

            //args.Add(String.Format("{0:0.000}", (double)steplength / 1000));

            if (randomSeed != -1)
            {
                args.Add("--seed");
                args.Add(randomSeed.ToString());
            }
            else {
                args.Add("--xml-validation");
                args.Add("never");
            }
            args.Add("--start");
            String[] argsArray = args.ToArray();
            foreach (String arg in argsArray)
            {
                sumoArgs += " " + arg;
                //UnityEngine.Debug.Log(sumoArgs);
            }
            sumoProcess = new Process();
            sumoProcess.StartInfo.FileName = sumoEXE64;
            sumoProcess.StartInfo.Arguments = sumoArgs;
            Console.WriteLine(sumoArgs);
            try
            {
                sumoProcess.Start();
            }
            catch (IOException e)
            {
                if (!sumoEXE64.Equals(sumoEXE))
                {
                    //log.debug("Try it again (x64).");
                    sumoEXE64 = sumoEXE;
                    sumoProcess.Start();
                }
                else {
                    throw e;
                }
            }
            catch (Exception e)
            {
                throw new SystemException();
            }
            //StreamLogger localStreamLogger1 = new StreamLogger(this.sumoProcess.getErrorStream(), "SUMO-err:");
            //    StreamLogger localStreamLogger2 = new StreamLogger(this.sumoProcess.getInputStream(), "SUMO-out:");
            //new Thread(localStreamLogger1, "StreamLogger-SUMO-err").start();
            //new Thread(localStreamLogger2, "StreamLogger-SUMO-out").start();
        }

        private void findAvailablePort()

        {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            this.remotePort = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
        }

        public void close()
        {
            try
            {
                this.socket.Close();
            }
            catch (IOException localIOException)
            {
                //localIOException.StackTrace;
            }
        }

        private void closeAndDontCareAboutInterruptedException()
        {
            close();
        }

        public bool isClosed()
        {
            return ((socket == null) || !SocketConnected(socket));
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public /*synchronized*/ void do_job_set(SumoCommand sc)

        {
            if (isClosed())
            {
                throw new InvalidOperationException("connection is closed");
            }
            try
            {
                this.cp.do_job_set(sc);
            }
            catch (Exception localException)
            {
                closeAndDontCareAboutInterruptedException();
                throw localException;
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public /*synchronized*/ Object do_job_get(SumoCommand sc)

        {
            Object localObject = null;
            if (isClosed())
            {
                throw new InvalidOperationException("connection is closed");
            }
            try
            {
                localObject = this.cp.do_job_get(sc);
            }
            catch (Exception localException)
            {
                closeAndDontCareAboutInterruptedException();
                throw localException;
            }
            return localObject;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void do_timestep()
        {
            if (isClosed())
            {
                throw new InvalidOperationException("connection is closed");
            }
            try
            {
                this.cp.do_job_set(new SumoCommand(Convert.ToInt32(2), Convert.ToInt32(0)));
            }
            catch (Exception localException)
            {
                closeAndDontCareAboutInterruptedException();
                throw localException;
            }
        }

        //[MethodImpl(MethodImplOptions.Synchronized)]
        //public void do_timestep()
        //{
        //    if (isClosed())
        //    {
        //        throw new InvalidOperationException("connection is closed");
        //    }
        //    try
        //    {

        //        byte[] bytes = { 0, 0, 0, 14, 0, 0, 0, 0, 6, 2, 0, 0, 0, 0 };
        //        binWr.Write(bytes);
        //        //ns.Write(bytes, 0, bytes.Length);
        //        // ns.Flush();
        //        //byte aux = binRe.ReadByte();
        //        //Console.WriteLine("Readbytes: " + aux);

        //        //int i = 0;
        //        //while (true)
        //        //{
        //        //    Console.WriteLine("Reading byte timestep " + i + ": " + binRe.ReadByte());
        //        //    i++;
        //        //}

        //    }
        //    catch (Exception localException)
        //    {
        //        closeAndDontCareAboutInterruptedException();
        //        throw localException;
        //    }
        //}

        public void get_vehicle_list()
        {
            if (isClosed())
            {
                throw new InvalidOperationException("connection is closed");
            }
            try
            {
                // this.cp.do_job_set(new SumoCommand(Convert.ToInt32(2), Convert.ToInt32(0)));
                byte[] bytes = { 0, 0, 0, 12, 8, 0xa4, 0, 0, 0, 0, 1, 0 };
                binWr.Write(bytes);
                byte aux = binRe.ReadByte();
                Console.WriteLine("Readbytes vehicleList: " + aux);
                //for (int i = 0; i < aux; i++)
                //{
                    while (binRe.PeekChar() != -1)
                    {
                        Console.WriteLine("Reading byte list: " + binRe.ReadByte());
                    }
                //    else {
                //        Console.WriteLine("NO!!! i=" + i);
                //       // binRe.Dispose();
                //        break;
                //    }
                //}
            }
            catch (Exception localException)
            {
                closeAndDontCareAboutInterruptedException();
                throw localException;
            }
        }
        public void get_vehicle_count()
        {
            if (isClosed())
            {
                throw new InvalidOperationException("connection is closed");
            }
            try
            {
                // this.cp.do_job_set(new SumoCommand(Convert.ToInt32(2), Convert.ToInt32(0)));
                byte[] bytes = { 0, 0, 0, 12, 8, 0xa4, 1, 0 , 0, 0, 1, 0};
                binWr.Write(bytes);
                byte aux = binRe.ReadByte();
                Console.WriteLine("Readbytes vehicleCount: " + aux);
                //for (int i = 0; i < aux; i++)
                //{
                int i = 0;
                while (true)
                {
                    Console.WriteLine("Reading byte count "+i+": "+ binRe.ReadByte());
                    i++;
                }
                //    else {
                //        Console.WriteLine("NO!!! i=" + i);
                //       // binRe.Dispose();
                //        break;
                //    }
                //}
            }
            catch (Exception localException)
            {
                closeAndDontCareAboutInterruptedException();
                throw localException;
            }
        }

        private bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 & part2)
            {//connection is closed
                return false;
            }
            return true;
        }

    }

}
