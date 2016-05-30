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

        public static SumoCommand getJamLengthVehicle(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(24), loopID, Convert.ToInt32(189), Convert.ToInt32(9));
        }

        public static SumoCommand getJamLengthMeters(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(25), loopID, Convert.ToInt32(189), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepMeanSpeed(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(17), loopID, Convert.ToInt32(189), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepOccupancy(String loopID)
        {
            return new SumoCommand(Convert.ToInt32(173), Convert.ToInt32(19), loopID, Convert.ToInt32(189), Convert.ToInt32(11));
        }
    }

}
