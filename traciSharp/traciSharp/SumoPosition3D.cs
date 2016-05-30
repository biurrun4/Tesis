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

        public SumoPosition3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public String toString()
        {
            return this.x + "," + this.y + "," + this.z;
        }
    }

}
