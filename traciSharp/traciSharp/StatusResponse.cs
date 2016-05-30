using sumo.config;
using System;
using System.IO;
using traciSharp;

namespace traci.protocol
{
    public class StatusResponse
    {
        private readonly int id;
        private readonly int result;
        private readonly String description;

        /**
         * Constructor for a successful outcome without a description.
         * 
         * @param id
         */
        public StatusResponse(int id)
        {
            this.id = id;
            this.result = Constants.RTYPE_OK;
            this.description = "";
        }

        /**
         * Constructor for an outcome with a description.
         * 
         * @param id
         * @param result
         * @param description
         */
        public StatusResponse(int id, int result, String description)
        {
            this.id = id;
            this.result = result;
            this.description = description;
        }

        /**
         * Constructor from de-serialization.
         * 
         * @param packet
         * @throws IOException
         */
        public StatusResponse(Storage packet)
        {
            try
            {
                int len = packet.readByte();
                if (len == 0)
                    packet.readInt(); // length is ignored; we can derive it

                id = packet.readUnsignedByte();
                result = packet.readUnsignedByte();
                description = packet.readStringASCII();
            }
            catch (IOException e)
            {
                e.ToString();
            }
        }

        /**
         * 
         * @return the command ID that this response refers to
         */
        public int Id()
        {
            return id;
        }

        /**
         * @return the outcome description
         */
        public int Result()
        {
            return result;
        }

        /**
         * @return the description
         */
        public String Description()
        {
            return description;
        }

        /**
         * Serializes this object to the given {@link Storage}.
         * @param out
         */
        public void writeTo(Storage output)
        {
            output.writeByte(0);
            output.writeInt(11 + description.Length);
            output.writeByte(id);
            output.writeByte(result);
            output.writeStringASCII(description);
        }
    }
}
