using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.util;

namespace container
{
    [Serializable]
    public class SumoLinkList : List<SumoLink>
    {
        private const long serialVersionUID = -6530046166179152137L;
        private readonly List<SumoLink> list;

        public SumoLinkList()
        {
            this.list = new List<SumoLink>();
        }

        public SumoLinkList(List<SumoLink> paramList)
        {
            this.list = paramList;
        }

        public void add(int paramInt, SumoLink paramSumoLink)
        {
            this.list.Insert(paramInt, paramSumoLink);
        }

        public bool addAll(Collection<SumoLink> paramCollection)
        {
            list.AddRange(paramCollection);
            return true;
        }

        public bool addAll(int paramInt, Collection<SumoLink> paramCollection)
        {
            list.AddRange(paramCollection);
            return true;
        }

        public void clear()
        {
            this.list.Clear();
        }

        public bool contains(Object paramObject)
        {
            return this.list.Contains(paramObject);
        }

        public bool containsAll(Collection<SumoLink> paramCollection)
        {
            bool isIn = false;
            foreach (SumoLink slink in paramCollection)
            {
                if (!list.Contains(slink))
                {
                    isIn = true;
                }
            }
            return isIn;
        }

        public SumoLink get(int paramInt)
        {
            return (SumoLink)this.list[paramInt];
        }

        public int indexOf(Object paramObject)
        {
            return this.list.IndexOf((SumoLink)paramObject);
        }

        public bool isEmpty()
        {
            return !list.Any();
        }

        public int lastIndexOf(Object paramObject)
        {
            return this.list.LastIndexOf((SumoLink)paramObject);
        }

        public ListIterator<SumoLink> listIterator()
        {
            return new ListIterator<SumoLink>(list);
        }

        public ListIterator<SumoLink> listIterator(int paramInt)
        {
            return new ListIterator<SumoLink>(list, paramInt);
        }

        public bool remove(Object paramObject)
        {
            return list.Remove((SumoLink)paramObject);
        }

        public SumoLink remove(int index)
        {
            SumoLink value = list[index];
            list.RemoveAt(index);
            return value;
        }

        public bool removeAll(Collection<SumoLink> paramCollection)
        {
            bool change = false;
            foreach (SumoLink slink in paramCollection)
            {
                if (list.Contains(slink))
                {
                    list.Remove(slink);
                    change = true;
                }
            }
            return change;
        }

        public bool retainAll(Collection<SumoLink> paramCollection)
        {
            int i;
            bool[] isInList = new bool[list.Count];
            bool change = false;
            for (i = 0; i < list.Count; i++)
            {
                isInList[i] = false;
            }
            foreach (SumoLink slink in paramCollection)
            {
                if (list.Contains(slink))
                {
                    i = list.IndexOf(slink);
                    isInList[i] = true;
                }
            }
            for (i = 0; i < isInList.Length; i++)
            {
                if (isInList[i] == false)
                {
                    list.RemoveAt(i);
                }
            }
            return change;
        }

        public SumoLink set(int paramInt, SumoLink paramSumoLink)
        {
            return list[paramInt] = paramSumoLink;
        }

        public int size()
        {
            return this.list.Count;
        }

        public List<SumoLink> subList(int paramInt1, int paramInt2)
        {
            return list.GetRange(paramInt1, paramInt2);
        }

        public Object[] toArray()
        {
            return this.list.ToArray();
        }

        //public SumoLink[] toArray(T[] paramArrayOfT)
        //{
        //    return list.ToArray();
        //}

        public bool add(SumoLink paramSumoLink)
        {
            list.Add(paramSumoLink);
            return true;
        }

        public IEnumerator<SumoLink> iterator()
        {
            return this.list.GetEnumerator();
        }

        public String toString()
        {
            StringBuilder localStringBuilder = new StringBuilder();
            IEnumerator<SumoLink> localIterator = iterator();
            while (localIterator.MoveNext())
            {
                SumoLink localSumoLink = (SumoLink)localIterator.Current;
                localStringBuilder.Append(localSumoLink.toString() + "#");
            }
            return localStringBuilder.ToString();
        }
    }
}
