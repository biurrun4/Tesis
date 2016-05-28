using sumo.util;
using System;

namespace sumo.cmd
{

    public class Gui
    {
        public static SumoCommand getBoundary(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(163), paramString, Convert.ToInt32(188), Convert.ToInt32(5));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(0), "", Convert.ToInt32(188), Convert.ToInt32(14));
        }

        public static SumoCommand getOffset(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(161), paramString, Convert.ToInt32(188), Convert.ToInt32(1));
        }

        public static SumoCommand getSchema(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(162), paramString, Convert.ToInt32(188), Convert.ToInt32(12));
        }

        public static SumoCommand getZoom(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(160), paramString, Convert.ToInt32(188), Convert.ToInt32(11));
        }

        public static SumoCommand screenshot(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(165), paramString1, paramString2);
        }

        public static SumoCommand setBoundary(String paramString, double paramDouble1, double paramDouble2, double paramDouble3, double paramDouble4)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble1), Convert.ToDouble(paramDouble2), Convert.ToDouble(paramDouble3), Convert.ToDouble(paramDouble4) };
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(163), paramString, arrayOfObject);
        }

        public static SumoCommand setOffset(String paramString, double paramDouble1, double paramDouble2)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble1), Convert.ToDouble(paramDouble2) };
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(161), paramString, arrayOfObject);
        }

        public static SumoCommand setSchema(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(162), paramString1, paramString2);
        }

        public static SumoCommand setZoom(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(160), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand trackVehicle(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(166), paramString1, paramString2);
        }
    }

}
