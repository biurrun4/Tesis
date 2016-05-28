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

        public SumoBoundingBox(double paramDouble1, double paramDouble2, double paramDouble3, double paramDouble4)
        {
            this.x_min = paramDouble1;
            this.y_min = paramDouble2;
            this.x_max = paramDouble3;
            this.y_max = paramDouble4;
        }

        public String toString()
        {
            return this.x_min + "#" + this.y_min + "#" + this.x_max + "#" + this.y_max;
        }
    }
}
