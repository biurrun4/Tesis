using System;

namespace container
{
    public class SumoPosition3D
    {
        public double x;
        public double y;
        public double z;

        public SumoPosition3D()
        {
            this.x = 0.0D;
            this.y = 0.0D;
            this.z = 0.0D;
        }

        public SumoPosition3D(double paramDouble1, double paramDouble2, double paramDouble3)
        {
            this.x = paramDouble1;
            this.y = paramDouble2;
            this.z = paramDouble3;
        }

        public String toString()
        {
            return this.x + "," + this.y + "," + this.z;
        }
    }

}
