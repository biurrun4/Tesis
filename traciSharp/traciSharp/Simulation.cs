using container;
using sumo.util;
using System;

namespace sumo.cmd
{
    public class Simulation
    {
        public static SumoCommand convert2D(String edgeID, double pos, byte laneIndex, String toGeo)
        {
            Object[] arrayOfObject = { Convert.ToDouble(pos), Convert.ToByte(laneIndex), toGeo };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(130), edgeID, arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand convert3D(String edgeID, double pos, byte laneIndex, String toGeo)
        {
            Object[] arrayOfObject = { Convert.ToDouble(pos), Convert.ToByte(laneIndex), toGeo };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(130), edgeID, arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand convertGeo(double x, double y, String fromGeo)
        {
            Object[] arrayOfObject = { Convert.ToDouble(y), fromGeo };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(130), Convert.ToDouble(x), arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(14));
        }

        public static SumoCommand convertRoad(double x, double y, String isGeo)
        {
            Object[] arrayOfObject = { Convert.ToDouble(y), isGeo };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(66), Convert.ToDouble(x), arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(1));
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

        public static SumoCommand getDistance2D(double x1, double y1, double x2, double y2, bool isGeo, bool isDriving)
        {
            Object[] arrayOfObject = { new SumoPosition2D(x1, y1), new SumoPosition2D(x2, y2), Convert.ToBoolean(isGeo), Convert.ToBoolean(isDriving) };
            return new SumoCommand(Convert.ToInt32(171), Convert.ToInt32(131), arrayOfObject, Convert.ToInt32(187), Convert.ToInt32(11));
        }

        public static SumoCommand getDistanceRoad(String edgeID1, double pos1, String edgeID2, double pos2, bool isDriving)
        {
            Object[] arrayOfObject = { edgeID1, Convert.ToDouble(pos1), edgeID2, Convert.ToDouble(pos2), Convert.ToBoolean(isDriving) };
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
