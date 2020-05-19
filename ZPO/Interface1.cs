using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO
{
    public interface ISortMetod<T>
        where T : IComparable<T>
    {
        void Sort(IList<T> array);
    }

    public static class Rozszerzenia
    {
        /// <summary>
        /// Bubble Sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">Kolekcja obiektów do posortowania</param>
        public static void BubbleSorting<T>(this IList<T> array)
            where T : IComparable<T>
        {
            BubbleSort<T> sb = new BubbleSort<T>();
            sb.Sort(array);
        }

        public static void MergeSorting<T>(this IList<T> array)
            where T : IComparable<T>
        {
            MergeSort<T> ms = new MergeSort<T>();
            ms.Sort(array);
        }
    }
}
