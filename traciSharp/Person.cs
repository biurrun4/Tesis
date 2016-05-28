using sumo.util;
using System;

namespace sumo.cmd
{
    public class Person
    {
        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(1), "", Convert.ToInt32(190), Convert.ToInt32(9));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(0), "", Convert.ToInt32(190), Convert.ToInt32(14));
        }

        public static SumoCommand getNextEdge(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(193), paramString, Convert.ToInt32(190), Convert.ToInt32(12));
        }

        public static SumoCommand getSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(64), paramString, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getPosition(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(66), paramString, Convert.ToInt32(190), Convert.ToInt32(1));
        }

        public static SumoCommand getPosition3D(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(57), paramString, Convert.ToInt32(190), Convert.ToInt32(3));
        }

        public static SumoCommand getAngle(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(67), paramString, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getRoadID(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(80), paramString, Convert.ToInt32(190), Convert.ToInt32(12));
        }

        public static SumoCommand getTypeID(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(79), paramString, Convert.ToInt32(190), Convert.ToInt32(12));
        }

        public static SumoCommand getLanePosition(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(86), paramString, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getColor(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(69), paramString, Convert.ToInt32(190), Convert.ToInt32(17));
        }

        public static SumoCommand getPersonNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(103), paramString, Convert.ToInt32(190), Convert.ToInt32(9));
        }

        public static SumoCommand getLength(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(68), paramString, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getWaitingTime(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(122), paramString, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getWidth(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(77), paramString, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getMinGap(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(76), paramString, Convert.ToInt32(190), Convert.ToInt32(11));
        }
    }

}
