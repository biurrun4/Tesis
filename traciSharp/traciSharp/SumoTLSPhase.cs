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

        public SumoTLSPhase(int duration, int duration1, int duration2, String phasedef)
        {
            this.duration = duration;
            this.duration1 = duration1;
            this.duration2 = duration2;
            this.phasedef = phasedef;
        }

        public SumoTLSPhase(int duration, String phasedef)
        {
            this.duration = duration;
            this.duration1 = duration;
            this.duration2 = duration;
            this.phasedef = phasedef;
        }

        public String toString()
        {
            return this.phasedef + "#" + this.duration + "#" + this.duration1 + "#" + this.duration2;
        }
    }
}
