using sumo.util;
using System;

namespace sumo.cmd
{
    public class Edge
    {
        public static SumoCommand getAdaptedTraveltime(String paramString, int paramInt)
        {
            Object[] arrayOfObject = { Convert.ToInt32(paramInt) };
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(88), paramString, arrayOfObject, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getCO2Emission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(96), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getCOEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(97), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getEffort(String paramString, int paramInt)
        {
            Object[] arrayOfObject = { Convert.ToInt32(paramInt) };
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(89), paramString, arrayOfObject, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getFuelConsumption(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(101), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getHCEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(98), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(1), "", Convert.ToInt32(186), Convert.ToInt32(9));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(0), "", Convert.ToInt32(186), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepHaltingNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(20), paramString, Convert.ToInt32(186), Convert.ToInt32(9));
        }

        public static SumoCommand getLastStepLength(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(21), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepMeanSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(17), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepPersonIDs(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(26), paramString, Convert.ToInt32(186), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepOccupancy(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(19), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepVehicleIDs(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(18), paramString, Convert.ToInt32(186), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepVehicleNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(16), paramString, Convert.ToInt32(186), Convert.ToInt32(9));
        }

        public static SumoCommand getNOxEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(100), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getNoiseEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(102), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getPMxEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(99), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getTraveltime(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(90), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getWaitingTime(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(122), paramString, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand adaptTraveltime(String paramString, int paramInt)
        {
            return new SumoCommand(Convert.ToInt32(202), Convert.ToInt32(88), paramString, Convert.ToInt32(paramInt));
        }

        public static SumoCommand setEffort(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(202), Convert.ToInt32(89), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setMaxSpeed(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(202), Convert.ToInt32(65), paramString, Convert.ToDouble(paramDouble));
        }
    }
}
