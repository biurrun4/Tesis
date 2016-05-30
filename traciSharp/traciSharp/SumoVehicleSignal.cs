using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace container
{
    public class SumoVehicleSignal
    {
        List<Int32> ll_states;

        public SumoVehicleSignal(int code)
        {   
            String str = getDual(code);
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

        public bool getState(SumoVehicleSignalState signalstate)
        {
            bool state = false;
            if (((Int32)(this.ll_states[signalstate.getPos()]) == 1))
            {
                state = true;
            }
            return state;
        }

        private String getDual(int code)
        {
            if (code < 2)
            {
                return "" + code;
            }
            return getDual(code / 2) + code % 2;
        }
    }
}
