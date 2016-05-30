using sumo.util;
using System;

namespace sumo.cmd
{
    public class Inductionloop
    {
        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(0), "", Convert.ToInt32(176), Convert.ToInt32(14));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(1), "", Convert.ToInt32(176), Convert.ToInt32(9));
        }

        public static SumoCommand getLaneID(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(81), loopID, Convert.ToInt32(176), Convert.ToInt32(12));
        }

        public static SumoCommand getLastStepMeanLength(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(21), loopID, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepMeanSpeed(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(17), loopID, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepOccupancy(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(19), loopID, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepVehicleIDs(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(18), loopID, Convert.ToInt32(176), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepVehicleNumber(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(16), loopID, Convert.ToInt32(176), Convert.ToInt32(9));
        }

        public static SumoCommand getPosition(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(66), loopID, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getTimeSinceDetection(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(22), loopID, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getVehicleData(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(23), loopID, Convert.ToInt32(176), Convert.ToInt32(9));
        }
    }
}
