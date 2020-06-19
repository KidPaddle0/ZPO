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
        public static void SelectionSorting<T>(this IList<T> array)
           where T : IComparable<T>
        {
            SelectionSort<T> ss = new SelectionSort<T>();
            ss.Sort(array);
        }
        public static void QuickSorting<T>(this IList<T> array)
           where T : IComparable<T>
        {
            QuickSort<T> qs = new QuickSort<T>();
            qs.Sort(array);
        }
        public static void CountingSorting<T>(this IList<T> array)
           where T : IComparable<T>
        {
            CountingSort<T> cs = new CountingSort<T>();
            cs.Sort(array);
        }
        public static void BucketSorting<T>(this IList<T> array)
           where T : IComparable<T>
        {
            BucketSort<T> Bucket = new BucketSort<T>();
            Bucket.Sort(array);
        }
    }
}
