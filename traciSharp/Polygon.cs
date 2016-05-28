using container;
using sumo.util;
using System;

namespace sumo.cmd
{

    public class Polygon
    {
        public static SumoCommand getColor(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(69), paramString, Convert.ToInt32(184), Convert.ToInt32(17));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(0), "", Convert.ToInt32(184), Convert.ToInt32(14));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(1), "", Convert.ToInt32(184), Convert.ToInt32(9));
        }

        public static SumoCommand getShape(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(78), paramString, Convert.ToInt32(184), Convert.ToInt32(6));
        }

        public static SumoCommand getType(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(168), Convert.ToInt32(79), paramString, Convert.ToInt32(184), Convert.ToInt32(12));
        }

        public static SumoCommand add(String paramString1, SumoGeometry paramSumoGeometry, SumoColor paramSumoColor, bool paramBoolean, String paramString2, int paramInt)
        {
            Object[] arrayOfObject = { paramSumoGeometry, paramSumoColor, Convert.ToBoolean(paramBoolean), paramString2, Convert.ToInt32(paramInt) };
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(128), paramString1, arrayOfObject);
        }

        public static SumoCommand remove(String paramString, int paramInt)
        {
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(129), paramString, Convert.ToInt32(paramInt));
        }

        public static SumoCommand setColor(String paramString, SumoColor paramSumoColor)
        {
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(69), paramString, paramSumoColor);
        }

        public static SumoCommand setShape(String paramString, SumoStringList paramSumoStringList)
        {
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(78), paramString, paramSumoStringList);
        }

        public static SumoCommand setType(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(200), Convert.ToInt32(79), paramString1, paramString2);
        }
    }

}
