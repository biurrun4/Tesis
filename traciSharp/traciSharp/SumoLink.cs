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

        public SumoLink(String from, String to, String over)
        {
            this.from = from;
            this.to = to;
            this.over = over;
            this.type = 0;
        }

        public SumoLink(String notInternal, String Internal, byte priority, byte isOpen, byte hasFoe, double length, String state, String direction)
        {
            this.notInternalLane = notInternal;
            this.internalLane = Internal;
            this.hasPriority = priority;
            this.isOpen = isOpen;
            this.hasApproachingFoe = hasFoe;
            this.length = length;
            this.state = state;
            this.direction = direction;
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
