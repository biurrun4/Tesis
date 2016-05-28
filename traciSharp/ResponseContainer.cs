using System.Collections.Generic;

namespace traci.protocol
{

    public class ResponseContainer
    {
        private readonly StatusResponse status;
        private readonly Command response;
        private readonly List<Command> subResponses;

        public ResponseContainer(StatusResponse paramStatusResponse, Command paramCommand, List<Command> paramList)
        {
            this.status = paramStatusResponse;
            this.response = paramCommand;
            this.subResponses = paramList;
        }

        public ResponseContainer(StatusResponse paramStatusResponse, Command paramCommand)
        {
            this.status = paramStatusResponse;
            this.response = paramCommand;
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
