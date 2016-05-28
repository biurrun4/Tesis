using container;
using sumo.util;
using System;

namespace sumo.cmd
{
    public class Simulation
    {
        public static SumoCommand convert2D(String paramString1, double paramDouble, byte paramByte, String paramString2)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble), Convert.ToByte(paramByte), paramString2 };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(130), paramString1, arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand convert3D(String paramString1, double paramDouble, byte paramByte, String paramString2)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble), Convert.ToByte(paramByte), paramString2 };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(130), paramString1, arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand convertGeo(double paramDouble1, double paramDouble2, String paramString)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble2), paramString };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(130), Convert.ToDouble(paramDouble1), arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand convertRoad(double paramDouble1, double paramDouble2, String paramString)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble2), paramString };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(66), Convert.ToDouble(paramDouble1), arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(1));
        }

        public static SumoCommand getArrivedIDList()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(122), "", Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand getArrivedNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(121), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getBusStopWaiting()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(103), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getParkingEndingVehiclesIDList()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(111), "", Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand getParkingEndingVehiclesNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(110), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getParkingStartingVehiclesIDList()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(109), "", Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand getParkingStartingVehiclesNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(108), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getStopEndingVehiclesIDList()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(107), "", Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand getStopEndingVehiclesNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(106), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getStopStartingVehiclesIDList()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(105), "", Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand getStopStartingVehiclesNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(104), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getCurrentTime()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(112), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getDeltaT()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(123), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getDepartedIDList()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(116), "", Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand getDepartedNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(115), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getDistance2D(double paramDouble1, double paramDouble2, double paramDouble3, double paramDouble4, bool paramBoolean1, bool paramBoolean2)
        {
            Object[] arrayOfObject = { new SumoPosition2D(paramDouble1, paramDouble2), new SumoPosition2D(paramDouble3, paramDouble4), Convert.ToBoolean(paramBoolean1), Convert.ToBoolean(paramBoolean2) };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(131), arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(11));
        }

        public static SumoCommand getDistanceRoad(String paramString1, double paramDouble1, String paramString2, double paramDouble2, bool paramBoolean)
        {
            Object[] arrayOfObject = { paramString1, Convert.ToDouble(paramDouble1), paramString2, Convert.ToDouble(paramDouble2), Convert.ToBoolean(paramBoolean) };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(131), arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(11));
        }

        public static SumoCommand getEndingTeleportIDList()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(120), "", Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand getEndingTeleportNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(119), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getLoadedIDList()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(114), "", Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand getLoadedNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(113), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getMinExpectedNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(125), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand getNetBoundary()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(124), "", Convert.ToInt32(187), Convert.ToInt32(5));
        }

        public static SumoCommand getStartingTeleportIDList()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(118), "", Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand getStartingTeleportNumber()
        {
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(117), "", Convert.ToInt32(187), Convert.ToInt32(9));
        }

        public static SumoCommand clearPending(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(203), Convert.ToInt32(148), "", paramString);
        }

        public static SumoCommand saveState(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(203), Convert.ToInt32(149), "", paramString);
        }
    }
}
