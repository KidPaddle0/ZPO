using System;
using System.Collections.Generic;
using System.Text;


namespace ZPO
{
    public class QuickSort<T> : ISortMetod<T>
        where T : IComparable<T>
    {
        public void Sort(IList<T> array)
        {
            List<T> coppy = new List<T>(array);
            int left = 0;
            int right = array.Count - 1;
            qs(array, left, right);
        }
        public static void qs<T>(IList<T> array, int left, int right) where T : IComparable<T>
        {
            //int left = 0;
            //int right = array.Count - 1;
            int i = left, j = right;

            var pivot = array[left + (right - left) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                qs(array, left, j);

            if (i < right)
                qs(array, i, right);
        }
    }
}
