using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO
{
    public class BucketSort<T> where T : IComparable<T>
    {
        /*public IList<T> BucketS(List<T> array)
        {
            List<T> sorted = new List<T>();
            int numOfBUckets = 10;

            List<T>[] bucket = new List<T>[numOfBUckets];

            for (int i = 0; i < numOfBUckets; i++)
            {
                bucket[i] = new List<T>();
            }

            for (int i = 0; i < array.Count; i++)
            {
                T toBucket = (array[i] / numOfBUckets); // List nie można dzielić  x.x
                bucket[toBucket].Add(array[i]);
            }
        }*/
    }
}
