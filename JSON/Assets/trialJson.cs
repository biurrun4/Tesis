using UnityEngine;
//using System.Diagnostics;
//using System.Net.Sockets;
//using System.Collections.Generic;
//using System.IO;
//using System;
//using System.Net;
//using System.Threading;
//using sumo.config;
//using traciSharp;

public class trialJson : MonoBehaviour
{
    
    //public List<GameObject> lista= new List<GameObject>(5);

    //// Use this for initialization
    //public const String TCP_NODELAY_PROPERTY = "True";
    //private const int CONNECT_RETRIES = 6;

    //private string configFile, sumoArgs, sumo;
    //private int randomSeed, port;
    //private tcpipSocket socket;
    //private List<string> args;
    //private int steplength;
    //private Process sumoProcess;

    //private BinaryReader dis;
    //private BinaryWriter dos;

    //void Start()
    //{
    //    //string json = "{\"x\":609.79,\"y\":1091.17}";
    //    ////Auto myObject = new Auto(609.79, 1091.17);

    //    //Auto myObject = JsonUtility.FromJson<Auto>(json);
    //    //UnityEngine.Debug.Log("X:" + myObject.x + " / y:" + myObject.y);
    //    //UnityEngine.Debug.Log("Json" + JsonUtility.ToJson(myObject));
    //    //UnityEngine.Debug.Log("Original" + json);
    //    //int i = 0;
    //    //for (i = 0; i < 5; i++)
    //    //{
    //    //    GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //    //    lista.Add(obj);
    //    //}
    //    //i= 0;
    //    //foreach (var obj in lista)
    //    //{    
    //    //    obj.transform.position = new Vector3((float)myObject.x, (float)myObject.y, i * 100);
    //    //    i++;
    //    //}


    //    args = new List<string>();
    //    steplength = 10000;
    //    configFile = "C:/Users/Biurrun/Tesis/Examples/Test2/Test2.sumo.cfg";
    //    randomSeed = -1;
    //    sumoProcess = new Process();
    //    runServer();
    //    // Configure the process using the StartInfo properties.
    //    //UnityEngine.Debug.Log(sumoArgs);
    //    //sumoProcess.StartInfo.FileName = sumo;
    //    //sumoProcess.StartInfo.Arguments = sumoArgs;
    //    //sumoProcess.Start();


    //}


    //void Update()
    //{

    //}
    //private void runServer()
    //{
    //    port = findAvailablePort();
    //    //UnityEngine.Debug.Log("Port: "+port);
    //    runSUMO(port, true);
    //    //UnityEngine.Debug.Log(Dns.GetHostEntry(Dns.GetHostName()).AddressList.ToString());
    //    //tryConnect(Dns.GetHostEntry(Dns.GetHostName()).AddressList[0], port, sumoProcess); //maybe
    //    tryConnect(IPAddress.Parse("127.0.0.1"), port, sumoProcess);
    //    postConnect();
    //}
    //private int findAvailablePort() //throws IOException
    //{
    //    TcpListener l = new TcpListener(IPAddress.Loopback, 0);
    //    l.Start();
    //    int port = ((IPEndPoint)l.LocalEndpoint).Port;
    //    l.Stop();
    //    return port;
    //}

    //private void runSUMO(int remotePort, bool withGui) //throws IOException
    //{
    //    /*String sumoEXE = System.GetProperty(SUMO_EXE_PROPERTY);
    //    if (sumoEXE == null)
    //    {
    //        sumoEXE = "sumo";
    //    }*/
    //    String sumoEXE = "sumo";
    //    if (withGui)
    //    {
    //        sumoEXE += "-gui";
    //    }

    //    String sumoEXE64 = sumoEXE;
    //    bool is64bit = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
    //    if (is64bit)
    //    {
    //        sumoEXE64 += "64";
    //    }

    //    //args.Add(sumo);
    //    args.Add("-c");
    //    args.Add(configFile);
    //    args.Add("--remote-port");
    //    args.Add(remotePort.ToString());
    //    args.Add("--step-length");

    //    args.Add(String.Format("{0:0.000}", (double)steplength / 1000));

    //    if (randomSeed != -1)
    //    {
    //        args.Add("--seed");
    //        args.Add(randomSeed.ToString());
    //    }
    //    else {
    //        args.Add("--xml-validation");
    //        args.Add("never");
    //    }

    //    String[] argsArray = args.ToArray();
    //    foreach (String arg in argsArray)
    //    {
    //        sumoArgs += " " + arg;
    //    }

    //    // this avoids validation of the input xml files; if SUMO_HOME is not set correctly,
    //    // sumo will try to download the schema files from the web and may wait 30 seconds at startup
    //    // for the connection to time out.
    //    //args.add(9, "--xml-validation");
    //    //args.add(10, "never");


    //    UnityEngine.Debug.Log("Executing SUMO with cmdline " + sumoArgs);
    //    sumoProcess = new Process();
    //    sumoProcess.StartInfo.FileName = sumoEXE64;
    //    sumoProcess.StartInfo.Arguments = sumoArgs;

    //    try
    //    {
    //        sumoProcess.Start();
    //    }
    //    catch (IOException e)
    //    {
    //        if (!sumoEXE64.Equals(sumoEXE))
    //        {
    //            //log.debug("Try it again (x64).");
    //            sumoEXE64 = sumoEXE;
    //            sumoProcess.Start();
    //        }
    //        else {
    //            throw e;
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        UnityEngine.Debug.Log(e);
    //    }
    //}

    //private void tryConnect(IPAddress addr, int port, Process process)
    //{
    //    socket = new tcpipSocket(port);
    //    int waitTime = 500; // milliseconds
    //    for (int i = 0; i < CONNECT_RETRIES; i++)
    //    {

    //        if (process != null)
    //        {
    //            try
    //            {
    //                int retVal = process.ExitCode;
    //                throw new IOException("SUMO process terminated unexpectedly with value " + retVal);
    //            }
    //            catch (Exception e)
    //            { //IllegalThreadStateException
    //                UnityEngine.Debug.Log("It's alive, go ahead " + e);
    //            }
    //            UnityEngine.Debug.Log("Connecting to " + addr + ":" + port);

    //            if (tryConnectOnce(addr, port))
    //            {
    //                UnityEngine.Debug.Log("Connection to SUMO established.");
    //                break;
    //            }
    //            else {
    //                UnityEngine.Debug.Log("Server not ready, retrying in " + waitTime + "ms");
    //                Thread.Sleep(waitTime);
    //                waitTime *= 2;
    //            }
    //        }
    //    }
    //}

    //private bool tryConnectOnce(IPAddress addr, int port)
    //{

    //    //bool tcpNoDelay = bool.Parse(TCP_NODELAY_PROPERTY);

    //    //socket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    //    ////UnityEngine.Debug.Log(AddressFamily.InterNetwork.ToString());
    //    ////UnityEngine.Debug.Log(SocketType.Stream.ToString());
    //    ////UnityEngine.Debug.Log(ProtocolType.Tcp.ToString());
    //    //socket.NoDelay = tcpNoDelay;

    //    try
    //    {
    //        //UnityEngine.Debug.Log("HOLA");
    //        socket.connect(new IPEndPoint(addr, port));
    //        return true;
    //    }
    //    catch (Exception ce)
    //    {
    //        //UnityEngine.Debug.Log("ADIOS");
    //        UnityEngine.Debug.Log(ce);
    //        return false;
    //    }
    //}

    //private void postConnect() //throws IOException
    //{
    //    for (int i = 0; i < 500; i++)
    //    {
    //        //UnityEngine.Debug.Log("i=" + i);
    //        send_commandSimulationStep(0);
    //        //Thread.Sleep(2);
    //    }
    //}

    //private void send_commandSimulationStep(int time)
    //{
    //    UnityEngine.Debug.Log("Hey");
    //    Storage outMsg = new Storage();
    //    outMsg.writeUnsignedByte(1 + 1 + 4);
    //    // command id
    //    outMsg.writeUnsignedByte(Constants.CMD_SIMSTEP2);
    //    outMsg.writeInt(time);
    //    socket.sendExact(outMsg);
    //    Storage inMsg = new Storage();
    //    //string acknowledgement = "";
    //    //check_resultState(inMsg, Constants.CMD_SIMSTEP2, false, acknowledgement);
    //}

    //public void check_resultState(Storage inMsg, int command, bool ignoreCommandId, string acknowledgement)
    //{
    //    UnityEngine.Debug.Log("hey");
    //    inMsg = socket.receiveExact();
    //    int cmdLength;
    //    int cmdId;
    //    int resultType;
    //    int cmdStart;
    //    string msg;
    //    try
    //    {
    //        UnityEngine.Debug.Log("hou");
    //        cmdStart = inMsg.Position();
    //        cmdLength = inMsg.readUnsignedByte();
    //        cmdId = inMsg.readUnsignedByte();
    //        if (command != cmdId && !ignoreCommandId)
    //        {
    //            UnityEngine.Debug.Log("#Error: received status response to command: " + cmdId.ToString() + " but expected: " + command.ToString());
    //        }
    //        resultType = inMsg.readUnsignedByte();
    //        msg = inMsg.readStringASCII();
    //        switch (resultType)
    //        {
    //            case Constants.RTYPE_ERR:
    //                UnityEngine.Debug.Log(".. Answered with error to command (" + command.ToString() + "), [description: " + msg + "]");
    //                break;
    //            case Constants.RTYPE_NOTIMPLEMENTED:
    //                UnityEngine.Debug.Log(".. Sent command is not implemented (" + command.ToString() + "), [description: " + msg + "]");
    //                break;
    //            case Constants.RTYPE_OK:
    //                if (acknowledgement != "")
    //                {
    //                    UnityEngine.Debug.Log(".. Command acknowledged (" + command.ToString() + "), [description: " + msg + "]");
    //                }
    //                break;
    //            default:
    //                UnityEngine.Debug.Log(".. Answered with unknown result code(" + resultType.ToString() + ") to command(" + command.ToString() + "), [description: " + msg + "]");
    //                break;
    //        }
    //        if ((cmdStart + cmdLength) != (int)inMsg.Position())
    //        {
    //            UnityEngine.Debug.Log("#Error: command at position " + cmdStart.ToString() + " has wrong length");
    //        }
    //    }
    //    catch (ArgumentException e)
    //    {
    //        UnityEngine.Debug.Log("#Error: an exception was thrown while reading result state message");
    //    }

    //}
}
