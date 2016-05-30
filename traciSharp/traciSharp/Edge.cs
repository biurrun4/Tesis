using sumo.util;
using System;

namespace sumo.cmd
{
    public class Edge
    {
        public static SumoCommand getAdaptedTraveltime(String edgeID, int time)
        {
            Object[] arrayOfObject = { Convert.ToInt32(time) };
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(88), edgeID, arrayOfObject, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getCO2Emission(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(96), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getCOEmission(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(97), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getEffort(String edgeID, int time)
        {
            Object[] arrayOfObject = { Convert.ToInt32(time) };
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(89), edgeID, arrayOfObject, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getFuelConsumption(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(101), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getHCEmission(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(98), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(1), "", Convert.ToInt32(186), Convert.ToInt32(9));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(0), "", Convert.ToInt32(186), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepHaltingNumber(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(20), edgeID, Convert.ToInt32(186), Convert.ToInt32(9));
        }

        public static SumoCommand getLastStepLength(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(21), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepMeanSpeed(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(17), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepPersonIDs(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(26), edgeID, Convert.ToInt32(186), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepOccupancy(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(19), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepVehicleIDs(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(18), edgeID, Convert.ToInt32(186), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepVehicleNumber(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(16), edgeID, Convert.ToInt32(186), Convert.ToInt32(9));
        }

        public static SumoCommand getNOxEmission(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(100), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getNoiseEmission(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(102), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getPMxEmission(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(99), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getTraveltime(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(90), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand getWaitingTime(String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(170), Convert.ToInt32(122), edgeID, Convert.ToInt32(186), Convert.ToInt32(11));
        }

        public static SumoCommand adaptTraveltime(String edgeID, int time)
        {
            return new SumoCommand(Convert.ToInt32(202), Convert.ToInt32(88), edgeID, Convert.ToInt32(time));
        }

        public static SumoCommand setEffort(String edgeID, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(202), Convert.ToInt32(89), edgeID, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setMaxSpeed(String edgeID, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(202), Convert.ToInt32(65), edgeID, Convert.ToDouble(paramDouble));
        }
    }
}
