using container;
using sumo.util;
using System;

namespace sumo.cmd
{
    public class Poi
    {
        public static SumoCommand add(String poiID, double x, double y, SumoColor color, String poiType, int layer)
        {
            Object[] arrayOfObject = { Convert.ToDouble(x), Convert.ToDouble(y), color, poiType, Convert.ToInt32(layer) };
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(128), poiID, arrayOfObject);
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(1), "", Convert.ToInt32(183), Convert.ToInt32(9));
        }

        public static SumoCommand getColor(String poiID)
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(69), poiID, Convert.ToInt32(183), Convert.ToInt32(17));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(0), "", Convert.ToInt32(183), Convert.ToInt32(14));
        }

        public static SumoCommand getPosition(String poiID)
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(66), poiID, Convert.ToInt32(183), Convert.ToInt32(1));
        }

        public static SumoCommand getType(String poiID)
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(79), poiID, Convert.ToInt32(183), Convert.ToInt32(12));
        }

        public static SumoCommand remove(String poiID, int layer)
        {
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(129), poiID, Convert.ToInt32(layer));
        }

        public static SumoCommand setColor(String poiID, SumoColor color)
        {
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(69), poiID, color);
        }

        public static SumoCommand setPosition(String poiID, double x, double y)
        {
            Object[] arrayOfObject = { Convert.ToDouble(x), Convert.ToDouble(y) };
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(66), poiID, arrayOfObject);
        }

        public static SumoCommand setType(String poiID, String poiType)
        {
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(79), poiID, poiType);
        }
    }

}
