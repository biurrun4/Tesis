using sumo.util;
using System;

namespace sumo.cmd
{
    public class Multientryexit
    {
        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(161), Convert.ToInt32(0), "", Convert.ToInt32(177), Convert.ToInt32(14));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(161), Convert.ToInt32(1), "", Convert.ToInt32(177), Convert.ToInt32(9));
        }

        public static SumoCommand getLastStepHaltingNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(161), Convert.ToInt32(20), paramString, Convert.ToInt32(177), Convert.ToInt32(9));
        }

        public static SumoCommand getLastStepMeanSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(161), Convert.ToInt32(17), paramString, Convert.ToInt32(177), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepVehicleIDs(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(161), Convert.ToInt32(18), paramString, Convert.ToInt32(177), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepVehicleNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(161), Convert.ToInt32(16), paramString, Convert.ToInt32(177), Convert.ToInt32(9));
        }
    }

}
