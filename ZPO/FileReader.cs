using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ZPO
{
    class FileReader
    {
        public static void Read(string fileName)
        {
            try
            {
                using (TextReader tr = File.OpenText(fileName))
                {
                    var line = tr.ReadToEnd();
                    int counter = 0;
                    int[] tab = new int[line.Length];
                    string[] bits = line.Split(' ');
                    
                    //while
                    for(int i = 0; i < 18; i++)
                    {
                        tab[i] = int.Parse(bits[i]);
                        counter++;
                    }
                    for (int i = 0; i < 18; i++)
                        Console.WriteLine(tab[i]);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
