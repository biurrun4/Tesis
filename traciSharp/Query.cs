using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using traci;
using traci.protocol;
using traciSharp;

namespace sumo.util
{
    public abstract class Query
    {
        private readonly BinaryWriter outStream;
        private readonly BinaryReader inStream;

        public Query(Socket paramSocket)
        {
            NetworkStream ns = new NetworkStream(paramSocket);
            this.outStream = new BinaryWriter(ns);
            this.inStream = new BinaryReader(ns);
        }

        protected ResponseMessage doQuery(RequestMessage paramRequestMessage)

        {
            paramRequestMessage.writeTo(getOutStream());
            return new ResponseMessage(this.inStream);
        }

        protected ResponseMessage queryAndVerify(RequestMessage paramRequestMessage)

        {
            paramRequestMessage.writeTo(getOutStream());
            ResponseMessage localResponseMessage = new ResponseMessage(this.inStream);
            List<Command> localList1 = paramRequestMessage.Commands();
            List<ResponseContainer> localList2 = localResponseMessage.responses();
            if (localList1.Count > localList2.Count)
            {
                throw new TraCIException("not enough responses received");
            }
            for (int i = 0; i < localList1.Count; i++)
            {
                Command localCommand = (Command)localList1[i];
                ResponseContainer localResponseContainer = (ResponseContainer)localList2[i];
                StatusResponse localStatusResponse = localResponseContainer.getStatus();
                verify("command and status IDs match", Convert.ToInt32(localCommand.Id()), Convert.ToInt32(localStatusResponse.Id()));
                if (localStatusResponse.Result() != 0)
                {
                    throw new TraCIException("SUMO error for command " + localStatusResponse.Id() + ": " + localStatusResponse.Description());
                }
            }
            return localResponseMessage;
        }

        protected ResponseContainer doQuerySingle(Command paramCommand)

        {
            RequestMessage localRequestMessage = new RequestMessage();
            localRequestMessage.append(paramCommand);
            ResponseMessage localResponseMessage = doQuery(localRequestMessage);
            IEnumerator <ResponseContainer> enumerator= localResponseMessage.responses().GetEnumerator();
            enumerator.MoveNext();
            return (ResponseContainer)enumerator.Current;
        }

        protected ResponseContainer queryAndVerifySingle(Command paramCommand)

        {
            RequestMessage localRequestMessage = new RequestMessage();
            localRequestMessage.append(paramCommand);
            ResponseMessage localResponseMessage = queryAndVerify(localRequestMessage);
            IEnumerator<ResponseContainer> enumerator = localResponseMessage.responses().GetEnumerator();
            enumerator.MoveNext();
            return (ResponseContainer)enumerator.Current;
        }

        protected static String verifyGetVarResponse(Command paramCommand, int paramInt1, int paramInt2, String paramString)

        {
            verify("response code", Convert.ToInt32(paramInt1), Convert.ToInt32(paramCommand.Id()));
            verify("variable ID", Convert.ToInt32(paramInt2), Convert.ToInt32(paramCommand.Content().readUnsignedByte()));
            String str = paramCommand.Content().readStringASCII();
            if (paramString != null)
            {
                verify("object ID", paramString, str);
            }
            return str;
        }

        protected static void verify(String paramString, Object paramObject1, Object paramObject2)

        {
            if (!paramObject2.Equals(paramObject1))
            {
                throw new TraCIException.UnexpectedData(paramString, paramObject1, paramObject2);
            }
        }

        protected static void verify(String paramString, int paramInt, short paramShort)

        {
            verify(paramString, Convert.ToInt32(paramInt), Convert.ToInt32(paramShort));
        }

        protected static void verify(String paramString, int paramInt, byte paramByte)

        {
            verify(paramString, Convert.ToInt32(paramInt), Convert.ToInt32(paramByte));
        }

        public BinaryWriter getOutStream()
        {
            return this.outStream;
        }
    }
}


