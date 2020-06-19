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
           // var tableRead = File.ReadAllLines(fileName);
            //var tableToSort = new List<T>(tableRead);
            //FileReader.Read(fileName);
            List<string> stringList = new List {
                "adsf",
                "adsfl;jkadsf",
                "qwerp9oui",
                "a",
                ";ljsdfqweroiusd",
                "zcxv,mnzxcvnm,k"
            };

            int wieloscZbiru = 10000;

            Console.WriteLine("Sortowanie bąbelkowe: ");
            DateTime start = DateTime.Now;
            TestBubble(wieloscZbiru);
            DateTime end = DateTime.Now;
            Console.WriteLine($"\nCzas wykonania: {(end - start).TotalSeconds} s");
            Console.WriteLine($"Czas CPU: {Process.GetCurrentProcess().TotalProcessorTime.TotalSeconds} s");

            Console.WriteLine("\nSortowanie przez wybór: ");
            start = DateTime.Now;
            TestSelection(wieloscZbiru);
            end = DateTime.Now;
            Console.WriteLine($"\nCzas wykonania: {(end - start).TotalSeconds} s");
            Console.WriteLine($"Czas CPU: {Process.GetCurrentProcess().TotalProcessorTime.TotalSeconds} s");

            Console.WriteLine("\nSortowanie szybkie: ");
            start = DateTime.Now;
            TestQuick(wieloscZbiru);
            end = DateTime.Now;
            Console.WriteLine($"\nCzas wykonania: {(end - start).TotalSeconds} s");
            Console.WriteLine($"Czas CPU: {Process.GetCurrentProcess().TotalProcessorTime.TotalSeconds} s");

            Console.WriteLine("\nSortowanie przez scalanie: ");
            start = DateTime.Now;
            TestMerge(wieloscZbiru);
            end = DateTime.Now;
            Console.WriteLine($"\nCzas wykonania: {(end - start).TotalSeconds} s");
            Console.WriteLine($"Czas CPU: {Process.GetCurrentProcess().TotalProcessorTime.TotalSeconds} s");
        }

        private static void TestBubble(int n)
        {
            Random rand = new Random(12345);
            float[] tab = new float[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = (float)(rand.NextDouble() * 10);
            }
            tab.BubbleSorting();
            //foreach (var i in tab)
            //    Console.Write($"{i} ");
        }
        private static void TestSelection(int n)
        {
            Random rand = new Random(12345);
            float[] tab = new float[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = (float)(rand.NextDouble() * 10);
            }
            tab.SelectionSorting();
            //foreach (var i in tab)
            //    Console.Write($"{i} ");
        }
        private static void TestQuick(int n)
        {
            Random rand = new Random(12345);
            float[] tab = new float[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = (float)(rand.NextDouble() * 10);
            }
            tab.QuickSorting();
            //foreach (var i in tab)
            //    Console.Write($"{i} ");
        }
        private static void TestMerge(int n)
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
