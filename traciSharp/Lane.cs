using container;
using sumo.util;
using System;

namespace sumo.cmd
{

    public class Lane
    {
        public static SumoCommand getAllowed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(52), paramString, Convert.ToInt32(179), Convert.ToInt32(14));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(1), "", Convert.ToInt32(179), Convert.ToInt32(9));
        }

        public static SumoCommand getCO2Emission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(96), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getCOEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(97), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getDisallowed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(53), paramString, Convert.ToInt32(179), Convert.ToInt32(14));
        }

        public static SumoCommand getEdgeID(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(49), paramString, Convert.ToInt32(179), Convert.ToInt32(12));
        }

        public static SumoCommand getFuelConsumption(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(101), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getHCEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(98), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(0), "", Convert.ToInt32(179), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepHaltingNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(20), paramString, Convert.ToInt32(179), Convert.ToInt32(9));
        }

        public static SumoCommand getLastStepLength(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(21), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepMeanSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(17), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepOccupancy(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(19), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getLastStepVehicleIDs(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(18), paramString, Convert.ToInt32(179), Convert.ToInt32(14));
        }

        public static SumoCommand getLastStepVehicleNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(16), paramString, Convert.ToInt32(179), Convert.ToInt32(9));
        }

        public static SumoCommand getLength(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(68), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getLinkNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(48), paramString, Convert.ToInt32(179), Convert.ToInt32(7));
        }

        public static SumoCommand getLinks(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(51), paramString, Convert.ToInt32(179), Convert.ToInt32(15));
        }

        public static SumoCommand getMaxSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(65), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getNOxEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(100), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getNoiseEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(102), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getPMxEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(99), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getShape(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(78), paramString, Convert.ToInt32(179), Convert.ToInt32(6));
        }

        public static SumoCommand getTraveltime(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(90), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getWidth(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(77), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand getWaitingTime(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(163), Convert.ToInt32(122), paramString, Convert.ToInt32(179), Convert.ToInt32(11));
        }

        public static SumoCommand setAllowed(String paramString, SumoStringList paramSumoStringList)
        {
            return new SumoCommand(Convert.ToInt32(195), Convert.ToInt32(52), paramString, paramSumoStringList);
        }

        public static SumoCommand setDisallowed(String paramString, SumoStringList paramSumoStringList)
        {
            return new SumoCommand(Convert.ToInt32(195), Convert.ToInt32(53), paramString, paramSumoStringList);
        }

        public static SumoCommand setLength(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(195), Convert.ToInt32(68), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setMaxSpeed(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(195), Convert.ToInt32(65), paramString, Convert.ToDouble(paramDouble));
        }
    }

}
