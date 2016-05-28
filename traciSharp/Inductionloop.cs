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

        public static SumoCommand getLaneID(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(81), paramString, Convert.ToInt32(176), Convert.ToInt32(12));
        }

        public static SumoCommand getLastStepMeanLength(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(21), paramString, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepMeanSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(17), paramString, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepOccupancy(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(19), paramString, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepVehicleIDs(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(18), paramString, Convert.ToInt32(176), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepVehicleNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(16), paramString, Convert.ToInt32(176), Convert.ToInt32(9));
        }

        public static SumoCommand getPosition(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(66), paramString, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getTimeSinceDetection(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(22), paramString, Convert.ToInt32(176), Convert.ToInt32(11));
        }

        public static SumoCommand getVehicleData(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(160), Convert.ToInt32(23), paramString, Convert.ToInt32(176), Convert.ToInt32(9));
        }
    }
}
