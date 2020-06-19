using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO
{
    public class BucketSort<T> : ISortMetod<T>
        where T : IComparable<T>
    {
        public void Sort(IList<T> array)
        {
            List<T> coppy = new List<T>(array);
            Bucket(array);
        }
        static public void Bucket<T>(List<T> array)
        {
            /* .... */
        }
    }
}
