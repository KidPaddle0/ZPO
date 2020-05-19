using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ZPO
{
    public class MergeSort<T> : ISortMetod<T>
         where T : IComparable<T>
    {
        public void Sort(IList<T> array)
        {
            List<T> coppy = new List<T>(array);
            //MS(array, 0, array.Count - 1, coppy);
            MS_Parallax(array, 0, array.Count - 1, coppy, 0, 6);
        }
        private void MS(IList<T> sorted, int start, int end, IList<T> source)
        {
            if (start == end)
                return;
            int end_1 = (start + end) / 2;
            MS(source, start, end_1, sorted);
            MS(source, end_1 + 1, end, sorted);
            Merge(source, start, end_1, end, sorted);
        }

        private void Merge(IList<T> source, int start, int end_1, int end, IList<T> sorted)
        {
            int iA = start, iB = end_1 + 1, iC = start;
            while (iA <= end_1 || iB <= end)
                if (iA <= end_1 && (iB > end || source[iA].CompareTo(source[iB]) <= 0))
                    sorted[iC++] = source[iA++];
                else
                    sorted[iC++] = source[iB++];
        }

        private void MS_Parallax(IList<T> sorted, int start, int end, IList<T> source, int deep, int limit)
        {
            if (start == end)
                return;
            int end_1 = (start + end) / 2;

            if (deep >= limit)
            {
                MS(source, start, end_1, sorted);
                MS(source, end_1 + 1, end, sorted);
            }
            else
            {
                Thread t1 = new Thread(delegate ()
                {
                    MS_Parallax(source, start, end_1, sorted, deep + 1, limit);
                });
                t1.Start();
                Thread t2 = new Thread(delegate ()
                {
                    MS_Parallax(source, end_1 + 1, end, sorted, deep + 1, limit);
                });
                t2.Start();
                t1.Join();
                t2.Join();
            }

            Merge(source, start, end_1, end, sorted);
        }

    }
}
