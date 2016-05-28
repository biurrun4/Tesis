using sumo.config;
using System.Collections.Generic;
using System.IO;
using traciSharp;

namespace traci.protocol
{
    public class ResponseMessage
    {
        public static readonly int[] STATUS_ONLY_RESPONSES = {
        Constants.CMD_CLOSE,
        Constants.CMD_SET_LANE_VARIABLE,
        Constants.CMD_SET_TL_VARIABLE,
        Constants.CMD_SET_VEHICLE_VARIABLE,
        Constants.CMD_SET_POI_VARIABLE,
        Constants.CMD_SET_POLYGON_VARIABLE,
        Constants.CMD_SET_EDGE_VARIABLE,
        Constants.CMD_SET_GUI_VARIABLE,
        Constants.CMD_SET_ROUTE_VARIABLE, };
        private List<ResponseContainer> pairs = new List<ResponseContainer>();

        public ResponseMessage(BinaryReader paramDataInputStream)

        {
            int len = paramDataInputStream.ReadInt32() - 4;
            byte[] arrayOfByte = new byte[len];
            paramDataInputStream.Read(arrayOfByte, 0, arrayOfByte.Length);
            Storage localStorage = new Storage(arrayOfByte);
            while (localStorage.validPos())
            {
                StatusResponse localStatusResponse = new StatusResponse(localStorage);
                ResponseContainer localResponseContainer;
                if (localStatusResponse.Result() != 0)
                {
                    localResponseContainer = new ResponseContainer(localStatusResponse, null);
                }
                else if (localStatusResponse.Id() == 2)
                {
                    int j = localStorage.readInt();
                    List<Command> localArrayList = new List<Command>(j);
                    for (int k = 0; k < j; k++) {
                        localArrayList.Add(new Command(localStorage));
                    }
                    localResponseContainer = new ResponseContainer(localStatusResponse, null, localArrayList);
                }
                else if (isStatusOnlyResponse(localStatusResponse.Id()))
                {
                    localResponseContainer = new ResponseContainer(localStatusResponse, null);
                }
                else
                {
                    localResponseContainer = new ResponseContainer(localStatusResponse, new Command(localStorage));
                }
                this.pairs.Add(localResponseContainer);
            }
        }

        private bool isStatusOnlyResponse(int paramInt)
        {
            foreach (int k in STATUS_ONLY_RESPONSES)
            {
                if (k == paramInt)
                {
                    return true;
                }
            }
            return false;
        }

        public List<ResponseContainer> responses()
        {
            return this.pairs;
        }
    }
}
