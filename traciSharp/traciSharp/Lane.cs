using container;
using sumo.util;
using System;

namespace sumo.cmd
{

    public class Lane
    {
        public static SumoCommand getAllowed(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(52), laneID, Convert.ToInt32(179), Convert.ToInt32(14));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(1), "", Convert.ToInt32(179), Convert.ToInt32(9));
        }

        public static SumoCommand getCO2Emission(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(96), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getCOEmission(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(97), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getDisallowed(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(53), laneID, Convert.ToInt32(179), Convert.ToInt32(14));
        }

        public static SumoCommand getEdgeID(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(49), laneID, Convert.ToInt32(179), Convert.ToInt32(12));
        }

        public static SumoCommand getFuelConsumption(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(101), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getHCEmission(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(98), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(0), "", Convert.ToInt32(179), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepHaltingNumber(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(20), laneID, Convert.ToInt32(179), Convert.ToInt32(9));
        }

        public static SumoCommand getLastStepLength(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(21), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepMeanSpeed(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(17), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepOccupancy(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(19), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepVehicleIDs(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(18), laneID, Convert.ToInt32(179), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepVehicleNumber(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(16), laneID, Convert.ToInt32(179), Convert.ToInt32(9));
        }

        public static SumoCommand getLength(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(68), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getLinkNumber(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(48), laneID, Convert.ToInt32(179), Convert.ToInt32(7));
        }

        public static SumoCommand getLinks(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(51), laneID, Convert.ToInt32(179), Convert.ToInt32(15));
        }

        public static SumoCommand getMaxSpeed(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(65), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getNOxEmission(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(100), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getNoiseEmission(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(102), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getPMxEmission(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(99), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getShape(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(78), laneID, Convert.ToInt32(179), Convert.ToInt32(6));
        }

        public static SumoCommand getTraveltime(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(90), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getWidth(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(77), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getWaitingTime(String laneID)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(122), laneID, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand setAllowed(String laneID, SumoStringList paramSumoStringList)
        {
            return new SumoCommand(Convert.ToInt32(195), Convert.ToInt32(52), laneID, paramSumoStringList);
        }

        public static SumoCommand setDisallowed(String laneID, SumoStringList paramSumoStringList)
        {
            return new SumoCommand(Convert.ToInt32(195), Convert.ToInt32(53), laneID, paramSumoStringList);
        }

        public static SumoCommand setLength(String laneID, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(195), Convert.ToInt32(68), laneID, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setMaxSpeed(String laneID, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(195), Convert.ToInt32(65), laneID, Convert.ToDouble(paramDouble));
        }
    }

}
