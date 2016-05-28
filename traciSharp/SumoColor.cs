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

        public SumoColor(int paramInt1, int paramInt2, int paramInt3, int paramInt4)
        {
            this.r = ((byte)paramInt1);
            this.g = ((byte)paramInt2);
            this.b = ((byte)paramInt3);
            this.a = ((byte)paramInt4);
        }

        public String toString()
        {
            return this.r + "#" + this.g + "#" + this.b + "#" + this.a;
        }
    }

}
