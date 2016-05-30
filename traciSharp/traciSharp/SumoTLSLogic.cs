using System;
using System.Collections.Generic;
using System.Text;

namespace container
{
    public class SumoTLSLogic
    {
        public String subID;
        public int type;
        public int subParameter;
        public int currentPhaseIndex;
        public List<SumoTLSPhase> phases;

        public SumoTLSLogic()
        {
            this.subID = "unkown";
            this.type = -1;
            this.subParameter = -1;
            this.currentPhaseIndex = -1;
            this.phases = new List<SumoTLSPhase>();
        }

        public SumoTLSLogic(String subID, int type, int subParameter, int currentPhaseIndex)
        {
            this.subID = subID;
            this.type = type;
            this.subParameter = subParameter;
            this.currentPhaseIndex = currentPhaseIndex;
            this.phases = new List<SumoTLSPhase>();
        }

        public void add(SumoTLSPhase phase)
        {
            this.phases.Add(phase);
        }

        public String toString()
        {
            StringBuilder localStringBuilder = new StringBuilder();
            localStringBuilder.Append(this.subID + "#");
            localStringBuilder.Append(this.type + "#");
            localStringBuilder.Append(this.subParameter + "#");
            localStringBuilder.Append(this.currentPhaseIndex + "#");
            IEnumerator<SumoTLSPhase> localIterator = this.phases.GetEnumerator();
            while (localIterator.MoveNext())
            {
                SumoTLSPhase localSumoTLSPhase = (SumoTLSPhase)localIterator.Current;
                localStringBuilder.Append(localSumoTLSPhase.toString() + "#");
            }
            return localStringBuilder.ToString();
        }
    }
}
