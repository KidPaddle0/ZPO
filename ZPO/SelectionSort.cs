using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO
{
    class SelectionSort
    {
/*        public void ss(IList<T> array)
        {
            List<T> coppy = new List<T>(array);
            ss(array);
        }*/
        public void ss<T>(T[] array) where T : IComparable
        {
            int n = array.Length;
            for (int i = 0; i < array.Length - 1; i++)
            {
                T min = array[i];
                int minLoc = i;

                for (int j = i + 1; j < array.Length; j++)
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
