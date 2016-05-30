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

        public static SumoCommand getNextEdge(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(193), personID, Convert.ToInt32(190), Convert.ToInt32(12));
        }

        public static SumoCommand getSpeed(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(64), personID, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getPosition(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(66), personID, Convert.ToInt32(190), Convert.ToInt32(1));
        }

        public static SumoCommand getPosition3D(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(57), personID, Convert.ToInt32(190), Convert.ToInt32(3));
        }

        public static SumoCommand getAngle(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(67), personID, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getRoadID(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(80), personID, Convert.ToInt32(190), Convert.ToInt32(12));
        }

        public static SumoCommand getTypeID(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(79), personID, Convert.ToInt32(190), Convert.ToInt32(12));
        }

        public static SumoCommand getLanePosition(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(86), personID, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getColor(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(69), personID, Convert.ToInt32(190), Convert.ToInt32(17));
        }

        public static SumoCommand getPersonNumber(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(103), personID, Convert.ToInt32(190), Convert.ToInt32(9));
        }

        public static SumoCommand getLength(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(68), personID, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getWaitingTime(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(122), personID, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getWidth(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(77), personID, Convert.ToInt32(190), Convert.ToInt32(11));
        }

        public static SumoCommand getMinGap(String personID)
        {
            return new SumoCommand(Convert.ToInt32(174), Convert.ToInt32(76), personID, Convert.ToInt32(190), Convert.ToInt32(11));
        }
    }

}
