using sumo.util;
using System;

namespace sumo.cmd
{
    public class ArealDetector
    {
        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(0), "", Convert.ToInt32(189), Convert.ToInt32(14));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(1), "", Convert.ToInt32(189), Convert.ToInt32(9));
        }

        public static SumoCommand getJamLengthVehicle(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(24), paramString, Convert.ToInt32(189), Convert.ToInt32(9));
        }

        public static SumoCommand getJamLengthMeters(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(25), paramString, Convert.ToInt32(189), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepMeanSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(17), paramString, Convert.ToInt32(189), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepOccupancy(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(19), paramString, Convert.ToInt32(189), Convert.ToInt32(11));
        }
    }

}
