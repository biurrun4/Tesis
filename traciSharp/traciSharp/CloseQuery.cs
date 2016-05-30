using sumo.util;
using System.Net.Sockets;
using traci.protocol;

namespace traciSharp
{
    public class CloseQuery : Query
    {
        public CloseQuery(Socket paramSocket) : base(paramSocket)

        {

        }

        public void doCommand()

        {
            Command localCommand = new Command(127);
            queryAndVerifySingle(localCommand);
        }
    }
}
