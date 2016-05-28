using container;
using sumo.util;
using System;

namespace sumo.cmd
{

    public class Trafficlights
    {
        public static SumoCommand getCompleteRedYellowGreenDefinition(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(43), paramString, Convert.ToInt32(178), Convert.ToInt32(15));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(1), "", Convert.ToInt32(178), Convert.ToInt32(9));
        }

        public static SumoCommand getPhaseDuration(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(36), paramString, Convert.ToInt32(178), Convert.ToInt32(9));
        }

        public static SumoCommand getControlledLanes(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(38), paramString, Convert.ToInt32(178), Convert.ToInt32(14));
        }

        public static SumoCommand getControlledLinks(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(39), paramString, Convert.ToInt32(178), Convert.ToInt32(15));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(0), "", Convert.ToInt32(178), Convert.ToInt32(14));
        }

        public static SumoCommand getNextSwitch(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(45), paramString, Convert.ToInt32(178), Convert.ToInt32(9));
        }

        public static SumoCommand getPhase(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(40), paramString, Convert.ToInt32(178), Convert.ToInt32(9));
        }

        public static SumoCommand getProgram(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(41), paramString, Convert.ToInt32(178), Convert.ToInt32(12));
        }

        public static SumoCommand getRedYellowGreenState(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(162), Convert.ToInt32(32), paramString, Convert.ToInt32(178), Convert.ToInt32(12));
        }

        public static SumoCommand setCompleteRedYellowGreenDefinition(String paramString, SumoTLSLogic paramSumoTLSLogic)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(44), paramString, paramSumoTLSLogic);
        }

        public static SumoCommand setPhase(String paramString, int paramInt)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(34), paramString, Convert.ToInt32(paramInt));
        }

        public static SumoCommand setPhaseDuration(String paramString, int paramInt)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(36), paramString, Convert.ToInt32(paramInt));
        }

        public static SumoCommand setProgram(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(35), paramString1, paramString2);
        }

        public static SumoCommand setRedYellowGreenState(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(194), Convert.ToInt32(32), paramString1, paramString2);
        }
    }

}
