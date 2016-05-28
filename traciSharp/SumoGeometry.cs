using System;
using System.Collections.Generic;
using System.Text;

namespace container
{
    public class SumoGeometry
    {
        public LinkedList<SumoPosition2D> coords = new LinkedList<SumoPosition2D>();

        public void add(SumoPosition2D paramSumoPosition2D)
        {
            this.coords.AddLast(paramSumoPosition2D);
        }

        public String toString()
        {
            StringBuilder localStringBuilder = new StringBuilder();
            IEnumerator<SumoPosition2D> localIterator = this.coords.GetEnumerator();
            while (localIterator.MoveNext())
            {
                SumoPosition2D localSumoPosition2D = (SumoPosition2D)localIterator.Current;
                localStringBuilder.Append(localSumoPosition2D.x + ",");
                localStringBuilder.Append(localSumoPosition2D.y + " ");
            }
            return localStringBuilder.ToString().Trim();
        }

        public void fromString(String paramString)
        {
            String[] arrayOfString1 = paramString.Split(' ');
            foreach (String str in arrayOfString1)
            {
                String[] arrayOfString3 = str.Split(',');
                double d1 = Convert.ToDouble(arrayOfString3[0]);
                double d2 = Convert.ToDouble(arrayOfString3[1]);
                add(new SumoPosition2D(d1, d2));
            }
        }
    }
}
