using System.Collections.Generic;

namespace traci.protocol
{

    public class ResponseContainer
    {
        private readonly StatusResponse status;
        private readonly Command response;
        private readonly List<Command> subResponses;

        public ResponseContainer(StatusResponse paramStatusResponse, Command c, List<Command> list)
        {
            this.status = paramStatusResponse;
            this.response = c;
            this.subResponses = list;
        }

        public ResponseContainer(StatusResponse paramStatusResponse, Command c)
        {
            this.status = paramStatusResponse;
            this.response = c;
            this.subResponses = null;
        }

        public StatusResponse getStatus()
        {
            return this.status;
        }

        public Command getResponse()
        {
            return this.response;
        }

        public List<Command> getSubResponses()
        {
            return this.subResponses;
        }
    }
}
