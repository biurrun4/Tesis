using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace container
{
    public class SumoVehicleSignal
    {
        List<Int32> ll_states;

        public SumoVehicleSignal(int paramInt)
        {   
            String str = getDual(paramInt);
            String[] arrayOfString = Regex.Split(str,"(?!^)");
            arrayOfString = arrayOfString.Take(arrayOfString.Count() - 1).ToArray();
            this.ll_states = new List<Int32>();
            for (int i = 0; i < 14; i++)
            {
                this.ll_states.Add(Convert.ToInt32(0));
            }
            for (int i = arrayOfString.Length - 1; i > 0; i--)
            {
                int j = arrayOfString.Length - i - 1;
                this.ll_states[j] =  Convert.ToInt32(arrayOfString[i]);
            }
        }

        public bool getState(SumoVehicleSignalState paramSumoVehicleSignalState)
        {
            bool state = false;
            if (((Int32)(this.ll_states[paramSumoVehicleSignalState.getPos()]) == 1))
            {
                state = true;
            }
            return state;
        }

        private String getDual(int paramInt)
        {
            if (paramInt < 2)
            {
                return "" + paramInt;
            }
            return getDual(paramInt / 2) + paramInt % 2;
        }
    }
}
