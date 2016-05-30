using sumo.util;
using System;

namespace sumo.cmd
{

    public class Gui
    {
        public static SumoCommand getBoundary(String viewID)
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(163), viewID, Convert.ToInt32(188), Convert.ToInt32(5));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(0), "", Convert.ToInt32(188), Convert.ToInt32(14));
        }

        public static SumoCommand getOffset(String viewID)
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(161), viewID, Convert.ToInt32(188), Convert.ToInt32(1));
        }

        public static SumoCommand getSchema(String viewID)
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(162), viewID, Convert.ToInt32(188), Convert.ToInt32(12));
        }

        public static SumoCommand getZoom(String viewID)
        {
            return new SumoCommand(Convert.ToInt32(172), Convert.ToInt32(160), viewID, Convert.ToInt32(188), Convert.ToInt32(11));
        }

        public static SumoCommand screenshot(String viewID, String filename)
        {
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(165), viewID, filename);
        }

        public static SumoCommand setBoundary(String viewID, double xmin, double ymin, double xmax, double ymax)
        {
            Object[] arrayOfObject = { Convert.ToDouble(xmin), Convert.ToDouble(ymin), Convert.ToDouble(xmax), Convert.ToDouble(ymax) };
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(163), viewID, arrayOfObject);
        }

        public static SumoCommand setOffset(String viewID, double x, double y)
        {
            Object[] arrayOfObject = { Convert.ToDouble(x), Convert.ToDouble(y) };
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(161), viewID, arrayOfObject);
        }

        public static SumoCommand setSchema(String viewID, String schemeName)
        {
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(162), viewID, schemeName);
        }

        public static SumoCommand setZoom(String viewID, double zoom)
        {
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(160), viewID, Convert.ToDouble(zoom));
        }

        public static SumoCommand trackVehicle(String viewID, String vehID)
        {
            return new SumoCommand(Convert.ToInt32(204), Convert.ToInt32(166), viewID, vehID);
        }
    }

}
