using System;

namespace container
{
    public class SumoBoundingBox
    {
        public double x_min;
        public double y_min;
        public double x_max;
        public double y_max;

        public SumoBoundingBox()
        {
            this.x_min = 0.0D;
            this.y_min = 0.0D;
            this.x_max = 0.0D;
            this.y_max = 0.0D;
        }

        public SumoBoundingBox(double x_min, double y_min, double x_max, double y_max)
        {
            this.x_min = x_min;
            this.y_min = y_min;
            this.x_max = x_max;
            this.y_max = y_max;
        }

        public String toString()
        {
            return this.x_min + "#" + this.y_min + "#" + this.x_max + "#" + this.y_max;
        }
    }
}
