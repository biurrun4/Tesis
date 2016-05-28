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

        public SumoStringList(List<String> paramList)
        {
            this.list = paramList;
        }

        public void add(int paramInt, String paramString)
        {
            this.list.Insert(paramInt, paramString);
        }

        public bool addAll(Collection<String> paramCollection)
        {
            list.AddRange(paramCollection);
            return true;
        }

        public bool addAll(int paramInt, Collection<String> paramCollection)
        {
            list.InsertRange(paramInt, paramCollection);
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

        public bool containsAll(Collection<String> paramCollection)
        {
            bool isIn = false;
            foreach (String str in paramCollection)
            {
                if (!list.Contains(str))
                {
                    isIn = true;
                }
            }
            return isIn; ;
        }

        public String get(int paramInt)
        {
            return (String)this.list[paramInt];
        }

        public int indexOf(Object paramObject)
        {
            return this.list.IndexOf(paramObject.ToString());
        }

        public bool isEmpty()
        {
            return !list.Any();
        }

        public int lastIndexOf(Object paramObject)
        {
            return this.list.LastIndexOf(paramObject.ToString());
        }

        public ListIterator<String> listIterator()
        {
            return new ListIterator<String>(list);
        }

        public ListIterator<String> listIterator(int paramInt)
        {
            return new ListIterator<String>(list, paramInt);
        }

        public bool remove(Object paramObject)
        {
            return this.list.Remove(paramObject.ToString());
        }

        public String remove(int index)
        {
            String value = list[index];
            list.RemoveAt(index);
            return value;
        }

        public bool removeAll(Collection<String> paramCollection)
        {
            bool change = false;
            foreach (String str in paramCollection)
            {
                if (list.Contains(str))
                {
                    list.Remove(str);
                    change = true;
                }
            }
            return change;
        }

        public bool retainAll(Collection<String> paramCollection)
        {
            int i;
            bool[] isInList = new bool[list.Count];
            bool change = false;
            for (i = 0; i < list.Count; i++)
            {
                isInList[i] = false;
            }
            foreach (String str in paramCollection)
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

        public String set(int paramInt, String paramString)
        {
            return list[paramInt] = paramString;
        }

        public int size()
        {
            return this.list.Count;
        }

        public List<String> subList(int paramInt1, int paramInt2)
        {
            return list.GetRange(paramInt1, paramInt2);
        }

        public Object[] toArray()
        {
            return this.list.ToArray();
        }

        //public String[] toArray(T[] paramArrayOfT)
        //{
        //    return list.ToArray();
        //}

        public bool add(String paramString)
        {
            list.Add(paramString);
            return true;
        }

        public IEnumerator<String> iterator()
        {
            return this.list.GetEnumerator();
        }
    }
}
