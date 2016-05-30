using container;
using sumo.util;
using System;

namespace sumo.cmd
{
    public class Route
    {
        public static SumoCommand getEdges(String routeID)
        {
            return new SumoCommand(Convert.ToInt32(166), Convert.ToInt32(84), routeID, Convert.ToInt32(182), Convert.ToInt32(14));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(166), Convert.ToInt32(0), "", Convert.ToInt32(182), Convert.ToInt32(14));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(166), Convert.ToInt32(1), "", Convert.ToInt32(182), Convert.ToInt32(9));
        }

        public static SumoCommand add(String routeID, SumoStringList edges)
        {
            return new SumoCommand(Convert.ToInt32(198), Convert.ToInt32(128), routeID, edges);
        }
    }
}
