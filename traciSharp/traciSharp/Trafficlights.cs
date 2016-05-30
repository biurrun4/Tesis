using container;
using sumo.util;
using System;

namespace sumo.cmd
{

    public class Trafficlights
    {
        public static SumoCommand getCompleteRedYellowGreenDefinition(String elementID)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(43), elementID, Convert.ToInt32(178), Convert.ToInt32(15));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(1), "", Convert.ToInt32(178), Convert.ToInt32(9));
        }

        public static SumoCommand getPhaseDuration(String elementID)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(36), elementID, Convert.ToInt32(178), Convert.ToInt32(9));
        }

        public static SumoCommand getControlledLanes(String elementID)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(38), elementID, Convert.ToInt32(178), Convert.ToInt32(14));
        }

        public static SumoCommand getControlledLinks(String elementID)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(39), elementID, Convert.ToInt32(178), Convert.ToInt32(15));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(0), "", Convert.ToInt32(178), Convert.ToInt32(14));
        }

        public static SumoCommand getNextSwitch(String elementID)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(45), elementID, Convert.ToInt32(178), Convert.ToInt32(9));
        }

        public static SumoCommand getPhase(String elementID)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(40), elementID, Convert.ToInt32(178), Convert.ToInt32(9));
        }

        public static SumoCommand getProgram(String elementID)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(41), elementID, Convert.ToInt32(178), Convert.ToInt32(12));
        }

        public static SumoCommand getRedYellowGreenState(String elementID)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(32), elementID, Convert.ToInt32(178), Convert.ToInt32(12));
        }

        public static SumoCommand setCompleteRedYellowGreenDefinition(String elementID, SumoTLSLogic paramSumoTLSLogic)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(44), elementID, paramSumoTLSLogic);
        }

        public static SumoCommand setPhase(String elementID, int paramInt)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(34), elementID, Convert.ToInt32(paramInt));
        }

        public static SumoCommand setPhaseDuration(String elementID, int paramInt)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(36), elementID, Convert.ToInt32(paramInt));
        }

        public static SumoCommand setProgram(String elementID, String programID)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(35), elementID, programID);
        }

        public static SumoCommand setRedYellowGreenState(String elementID, String state)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(32), elementID, state);
        }
    }

}
