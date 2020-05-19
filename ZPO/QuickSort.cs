using System;
using System.Collections.Generic;
using System.Text;


namespace ZPO
{
    class QuickSort
    {
        public static void qs<T>(T[] array, int left, int right) where T : IComparable
        {
            int i = left, j = right;

            var pivot = array[left + (right - left) / 2];

            while(i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                    i++;

                while (array[j].CompareTo(pivot) > 0)
                    j--;

                if( i <= j )
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
