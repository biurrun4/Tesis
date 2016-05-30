using container;
using sumo.util;
using System;

namespace sumo.cmd
{

    public class Polygon
    {
        public static SumoCommand getColor(String polyID)
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(69), polyID, Convert.ToInt32(184), Convert.ToInt32(17));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(0), "", Convert.ToInt32(184), Convert.ToInt32(14));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(1), "", Convert.ToInt32(184), Convert.ToInt32(9));
        }

        public static SumoCommand getShape(String polyID)
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(78), polyID, Convert.ToInt32(184), Convert.ToInt32(6));
        }

        public static SumoCommand getType(String polyID)
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(79), polyID, Convert.ToInt32(184), Convert.ToInt32(12));
        }

        public static SumoCommand add(String polyID, SumoGeometry shape, SumoColor color, bool fill, String polyType, int layer)
        {
            Object[] arrayOfObject = { shape, color, Convert.ToBoolean(fill), polyType, Convert.ToInt32(layer) };
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(128), polyID, arrayOfObject);
        }

        public static SumoCommand remove(String polyID, int layer)
        {
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(129), polyID, Convert.ToInt32(layer));
        }

        public static SumoCommand setColor(String polyID, SumoColor color)
        {
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(69), polyID, color);
        }

        public static SumoCommand setShape(String polyID, SumoStringList shape)
        {
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(78), polyID, shape);
        }

        public static SumoCommand setType(String polyID, String polyType)
        {
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(79), polyID, polyType);
        }
    }

}
