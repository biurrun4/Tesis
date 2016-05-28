using container;
using sumo.util;
using System;

namespace sumo.cmd
{
    public class Poi
    {
        public static SumoCommand add(String paramString1, double paramDouble1, double paramDouble2, SumoColor paramSumoColor, String paramString2, int paramInt)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble1), Convert.ToDouble(paramDouble2), paramSumoColor, paramString2, Convert.ToInt32(paramInt) };
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(128), paramString1, arrayOfObject);
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(1), "", Convert.ToInt32(183), Convert.ToInt32(9));
        }

        public static SumoCommand getColor(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(69), paramString, Convert.ToInt32(183), Convert.ToInt32(17));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(0), "", Convert.ToInt32(183), Convert.ToInt32(14));
        }

        public static SumoCommand getPosition(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(66), paramString, Convert.ToInt32(183), Convert.ToInt32(1));
        }

        public static SumoCommand getType(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(167), Convert.ToInt32(79), paramString, Convert.ToInt32(183), Convert.ToInt32(12));
        }

        public static SumoCommand remove(String paramString, int paramInt)
        {
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(129), paramString, Convert.ToInt32(paramInt));
        }

        public static SumoCommand setColor(String paramString, SumoColor paramSumoColor)
        {
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(69), paramString, paramSumoColor);
        }

        public static SumoCommand setPosition(String paramString, double paramDouble1, double paramDouble2)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble1), Convert.ToDouble(paramDouble2) };
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(66), paramString, arrayOfObject);
        }

        public static SumoCommand setType(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(199), Convert.ToInt32(79), paramString1, paramString2);
        }
    }

}
