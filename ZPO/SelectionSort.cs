using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO
{
    public class SelectionSort<T>: ISortMetod<T>
        where T : IComparable<T>
    {
        public void Sort(IList<T> array)
        {
            List<T> coppy = new List<T>(array);
            ss(array);
        }
        public void ss<T>(IList<T> array) where T : IComparable<T>
        {
            int n = array.Count;
            for (int i = 0; i < array.Count - 1; i++)
            {
                T min = array[i];
                int minLoc = i;

                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[j].CompareTo(min) < 0)
                    {
                        min = array[j];
                        minLoc = j;
                    }
                }

                if(minLoc != i)
                {
                    T temp = array[minLoc];
                    array[minLoc] = array[i];
                    array[i] = temp;
                }
            }
        }

    }
}
