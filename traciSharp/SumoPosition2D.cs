using System;

namespace container
{
    public class SumoPosition2D
    {
        public double x;
        public double y;

        public SumoPosition2D()
        {
            this.x = 0.0D;
            this.y = 0.0D;
        }

        public SumoPosition2D(double paramDouble1, double paramDouble2)
        {
            this.x = paramDouble1;
            this.y = paramDouble2;
        }

        public String toString()
        {
            return this.x + "," + this.y;
        }
    }
}
