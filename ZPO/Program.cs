using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Enumeration;

namespace ZPO
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Console.WriteLine("Hello World!");

            //string fileName = "D:\\VisualStudio\\ZPO\\ZPO\\TextFile.txt";

           // var tableRead = File.ReadAllLines(fileName);
            //var tableToSort = new List<T>(tableRead);

            //FileReader.Read(fileName);

            var tab = new[] { 2, 543, 61, 123432, 4315, 140, -12, 3425, 2344, 53 };
            List<string> stringList = new List {
                "adsf",
                "adsfl;jkadsf",
                "qwerp9oui",
                "a",
                ";ljsdfqweroiusd",
                "zcxv,mnzxcvnm,k"
            };
            IList<string> sortedString = stringList.cs(w => w.Length);

            foreach (var i in tab)
                Console.Write( i + ", ");

            SortArray(tab);

            Console.WriteLine();
            foreach (var i in tab)
                Console.Write( i + " ");

            foreach (string s in sortedString)
                Console.WriteLine(s);
            DateTime start = DateTime.Now;
            TestSort(10000000);
            DateTime end = DateTime.Now;
            Console.WriteLine($"Czas wykonania: {(end - start).TotalSeconds} s");
            Console.WriteLine($"Czas CPU: {Process.GetCurrentProcess().TotalProcessorTime.TotalSeconds} s");
        }

        private static void SortArray<T>(T[] array) where T : IComparable
        {
            QuickSort.qs(array, 0, array.Length - 1);
            //CountingSort.cs(array => array.Lenght);
        }

        private static void TestSort(int n)
        {
            Random rand = new Random(12345);
            float[] tab = new float[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = (float)(rand.NextDouble() * 10);
            }
            tab.MergeSorting();
            //foreach (var i in tab)
            //    Console.Write($"{i} ");
        }
    }
}
