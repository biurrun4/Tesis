using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.util;

namespace container
{
    [Serializable]
    public class SumoStringList : List<String>
    {
        private const long serialVersionUID = -6530046166179152137L;
        private readonly List<String> list;

        public SumoStringList()
        {
            this.list = new List<String>();
        }

        public SumoStringList(List<String> list)
        {
            this.list = list;
        }

        public void add(int index, String element)
        {
            this.list.Insert(index, element);
        }

        public bool addAll(Collection<String> elements)
        {
            list.AddRange(elements);
            return true;
        }

        public bool addAll(int index, Collection<String> elements)
        {
            list.InsertRange(index, elements);
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

        public bool containsAll(Collection<String> elements)
        {
            bool isIn = false;
            foreach (String str in elements)
            {
                if (!list.Contains(str))
                {
                    isIn = true;
                }
            }
            return isIn; ;
        }

        public String get(int index)
        {
            return (String)this.list[index];
        }

        public int indexOf(Object element)
        {
            return this.list.IndexOf(element.ToString());
        }

        public bool isEmpty()
        {
            return !list.Any();
        }

        public int lastIndexOf(Object element)
        {
            return this.list.LastIndexOf(element.ToString());
        }

        public ListIterator<String> listIterator()
        {
            return new ListIterator<String>(list);
        }

        public ListIterator<String> listIterator(int index)
        {
            return new ListIterator<String>(list, index);
        }

        public bool remove(Object element)
        {
            return this.list.Remove(element.ToString());
        }

        public String remove(int index)
        {
            String value = list[index];
            list.RemoveAt(index);
            return value;
        }

        public bool removeAll(Collection<String> elements)
        {
            bool change = false;
            foreach (String str in elements)
            {
                if (list.Contains(str))
                {
                    list.Remove(str);
                    change = true;
                }
            }
            return change;
        }

        public bool retainAll(Collection<String> elements)
        {
            int i;
            bool[] isInList = new bool[list.Count];
            bool change = false;
            for (i = 0; i < list.Count; i++)
            {
                isInList[i] = false;
            }
            foreach (String str in elements)
            {
                if (list.Contains(str))
                {
                    i = list.IndexOf(str);
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

        public String set(int index, String element)
        {
            return list[index] = element;
        }

        public int size()
        {
            return this.list.Count;
        }

        public List<String> subList(int from, int to)
        {
            return list.GetRange(from, to);
        }

        public Object[] toArray()
        {
            return this.list.ToArray();
        }

        public bool add(String element)
        {
            list.Add(element);
            return true;
        }

        public IEnumerator<String> iterator()
        {
            return this.list.GetEnumerator();
        }
    }
}
