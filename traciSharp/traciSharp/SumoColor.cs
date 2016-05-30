using System;

namespace container
{
    public class SumoColor
    {
        public byte r;
        public byte g;
        public byte b;
        public byte a;

        public SumoColor()
        {
            this.r = 100;
            this.g = 100;
            this.b = 100;
            this.a = 100;
        }

        public SumoColor(int r, int g, int b, int a)
        {
            this.r = ((byte)r);
            this.g = ((byte)g);
            this.b = ((byte)b);
            this.a = ((byte)a);
        }

        public String toString()
        {
            return this.r + "#" + this.g + "#" + this.b + "#" + this.a;
        }
    }

}
