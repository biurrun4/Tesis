using sumo.util;
using System;

namespace sumo.cmd
{
    public class Junction
    {
        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(169), Convert.ToInt32(0), "", Convert.ToInt32(185), Convert.ToInt32(14));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(169), Convert.ToInt32(1), "", Convert.ToInt32(185), Convert.ToInt32(9));
        }

        public static SumoCommand getPosition(String junctionID)
        {
            return new SumoCommand(Convert.ToInt32(169), Convert.ToInt32(66), junctionID, Convert.ToInt32(185), Convert.ToInt32(1));
        }

        public static SumoCommand getShape(String junctionID)
        {
            return new SumoCommand(Convert.ToInt32(169), Convert.ToInt32(78), junctionID, Convert.ToInt32(185), Convert.ToInt32(6));
        }
    }
}
