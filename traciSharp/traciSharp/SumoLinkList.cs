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

        public SumoLinkList(List<SumoLink> list)
        {
            this.list = list;
        }

        public void add(int index, SumoLink sumolink)
        {
            this.list.Insert(index, sumolink);
        }

        public bool addAll(Collection<SumoLink> elements)
        {
            list.AddRange(elements);
            return true;
        }

        public bool addAll(int index, Collection<SumoLink> elements)
        {
            list.AddRange(elements);
            return true;
        }

        public void clear()
        {
            this.list.Clear();
        }

        public bool contains(Object element)
        {
            return this.list.Contains(element);
        }

        public bool containsAll(Collection<SumoLink> elements)
        {
            bool isIn = false;
            foreach (SumoLink slink in elements)
            {
                if (!list.Contains(slink))
                {
                    isIn = true;
                }
            }
            return isIn;
        }

        public SumoLink get(int index)
        {
            return (SumoLink)this.list[index];
        }

        public int indexOf(Object element)
        {
            return this.list.IndexOf((SumoLink)element);
        }

        public bool isEmpty()
        {
            return !list.Any();
        }

        public int lastIndexOf(Object element)
        {
            return this.list.LastIndexOf((SumoLink)element);
        }

        public ListIterator<SumoLink> listIterator()
        {
            return new ListIterator<SumoLink>(list);
        }

        public ListIterator<SumoLink> listIterator(int index)
        {
            return new ListIterator<SumoLink>(list, index);
        }

        public bool remove(Object element)
        {
            return list.Remove((SumoLink)element);
        }

        public SumoLink remove(int index)
        {
            SumoLink value = list[index];
            list.RemoveAt(index);
            return value;
        }

        public bool removeAll(Collection<SumoLink> elements)
        {
            bool change = false;
            foreach (SumoLink slink in elements)
            {
                if (list.Contains(slink))
                {
                    list.Remove(slink);
                    change = true;
                }
            }
            return change;
        }

        public bool retainAll(Collection<SumoLink> elements)
        {
            int i;
            bool[] isInList = new bool[list.Count];
            bool change = false;
            for (i = 0; i < list.Count; i++)
            {
                isInList[i] = false;
            }
            foreach (SumoLink slink in elements)
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

        public SumoLink set(int index, SumoLink sumolink)
        {
            return list[index] = sumolink;
        }

        public int size()
        {
            return this.list.Count;
        }

        public List<SumoLink> subList(int from, int to)
        {
            return list.GetRange(from, to);
        }

        public Object[] toArray()
        {
            return this.list.ToArray();
        }

        public bool add(SumoLink sumolink)
        {
            list.Add(sumolink);
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
