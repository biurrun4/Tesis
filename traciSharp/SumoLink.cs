using System;

namespace container
{
    public class SumoLink
    {
        public String from;
        public String to;
        public String over;
        public String notInternalLane;
        public String internalLane;
        public String state;
        public String direction;
        public byte hasPriority;
        public byte isOpen;
        public byte hasApproachingFoe;
        public double length;
        int type = 0;

        public SumoLink(String paramString1, String paramString2, String paramString3)
        {
            this.from = paramString1;
            this.to = paramString2;
            this.over = paramString3;
            this.type = 0;
        }

        public SumoLink(String paramString1, String paramString2, byte paramByte1, byte paramByte2, byte paramByte3, double paramDouble, String paramString3, String paramString4)
        {
            this.notInternalLane = paramString1;
            this.internalLane = paramString2;
            this.hasPriority = paramByte1;
            this.isOpen = paramByte2;
            this.hasApproachingFoe = paramByte3;
            this.length = paramDouble;
            this.state = paramString3;
            this.direction = paramString4;
            this.type = 1;
        }

        public String toString()
        {
            if (this.type == 0)
            {
                return this.from + "#" + this.over + "#" + this.to;
            }
            return this.notInternalLane + "#" + this.internalLane + "#" + this.hasPriority + "#" + this.isOpen + "#" + this.hasApproachingFoe + "#" + this.length + "#" + this.state + "#" + this.direction;
        }
    }

}
