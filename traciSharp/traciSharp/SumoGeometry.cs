using System;
using System.Collections.Generic;
using System.Text;

namespace container
{
    public class SumoGeometry
    {
        public LinkedList<SumoPosition2D> coords = new LinkedList<SumoPosition2D>();

        public void add(SumoPosition2D position2D)
        {
            this.coords.AddLast(position2D);
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

        public void fromString(String shape)
        {
            String[] arrayOfString1 = shape.Split(' ');
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
