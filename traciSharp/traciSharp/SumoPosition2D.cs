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

        public SumoPosition2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public String toString()
        {
            return this.x + "," + this.y;
        }
    }
}
