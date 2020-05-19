using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZPO
{
    public static class CountingSort
    {
        public static IList<T> cs<T>(this IList<T> array, Func<T, int> sortProp)
        {
            List<int> buckets = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                int value = sortProp(array[i]);

                for (int j = buckets.Count; j <= value; j++)
                    buckets.Add(0);
                
                buckets[value]++;
            }

            int[] startIndex = new int[buckets.Count];
            for (int j = 1; j < startIndex.Length; j++)
            {
                startIndex[j] = buckets[j - 1] + startIndex[j - 1];
            }

            T[] result = new T[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                int value = sortProp(array[i]);
                int desIndex = startIndex[value]++;
                result[desIndex] = array[i];
            }


            return result;
        }
    }
}
