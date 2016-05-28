using System;

namespace container
{

    public class SumoTLSPhase
    {
        public int duration;
        public int duration1;
        public int duration2;
        public String phasedef;

        public SumoTLSPhase()
        {
            this.duration = 0;
            this.duration1 = 0;
            this.duration2 = 0;
            this.phasedef = "r";
        }

        public SumoTLSPhase(int paramInt1, int paramInt2, int paramInt3, String paramString)
        {
            this.duration = paramInt1;
            this.duration1 = paramInt2;
            this.duration2 = paramInt3;
            this.phasedef = paramString;
        }

        public SumoTLSPhase(int paramInt, String paramString)
        {
            this.duration = paramInt;
            this.duration1 = paramInt;
            this.duration2 = paramInt;
            this.phasedef = paramString;
        }

        public String toString()
        {
            return this.phasedef + "#" + this.duration + "#" + this.duration1 + "#" + this.duration2;
        }
    }
}
