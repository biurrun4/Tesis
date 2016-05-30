using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using traciSharp;
using sumo.cmd;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net;

namespace TrialTraci
{
    class Program
    {
        //public static void step(NetworkStream bw, int j)
        //{
        //    byte[] bytes = { 0, 0, 0, 10, 6, 2, 0, 0, 0, 0 };
        //    bw.Write(bytes, 0, bytes.Length);
        //    bw.Flush();
        //}
        
        public static void Main(String[] argv)
        {

            //Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //socket.NoDelay = true;
            //try
            //{
            //    socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 60634));
            //}
            //catch (Exception localConnectException)
            //{
            //    Console.WriteLine(localConnectException.StackTrace.ToString());
            //}
            //NetworkStream ns = new NetworkStream(socket);
            ////BinaryWriter bw = new BinaryWriter(ns);
            //for (int i = 0; i < 1000; i++)
            //{
            //    step(ns,i);
            //}



            String configfile = "C:/Users/Biurrun/Tesis/Examples/Test2/Test2.sumo.cfg";
            //start Simulation
            int seed = -1;
            bool withGui = true;
            int steplength = 300;
            SumoTraciConnection conn = new SumoTraciConnection(configfile, seed, withGui,steplength);
            //conn.addOption("step-length", steplength);
            float simtime;
            try
            {

                //start TraCI
                conn.runServer();
                if (conn.isClosed())
                {
                    throw new InvalidOperationException("connection is closed");
                }

                //load routes and initialize the simulation
                conn.do_timestep();

                for (int i = 0; i < 500; i++)
                {
                    simtime = i * steplength; //ms
                                              //current simulation time
                                              //int simtime = (int)conn.do_job_get(Simulation.getCurrentTime());
                                              //Console.WriteLine(simtime);
                                              //conn.do_job_set(Vehicle.add("veh" + i, "car", "s1", simtime, 0, 13.8, (byte)1));

                    conn.do_timestep();
                }
                //conn.get_vehicle_count();
                //conn.get_vehicle_list();
                //stop TraCI
                conn.close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        }
}
