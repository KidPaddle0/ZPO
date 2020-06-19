using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ZPO
{
    public class BubbleSort<T> : ISortMetod<T>
        where T : IComparable<T>
    {
        public void Sort(IList<T> array)
        {
            List<T> coppy = new List<T>(array);
            bs(array);
        }
       public void bs(IList<T> array)
       { 
            for(int i = array.Count-1; i > 0; i--)
            {
                bool swap = false;
                for (int j = 1; j <= i; j++)
                {
                    if(array[j].CompareTo(array[j - 1]) < 0 )
                    {
                        T temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        swap = true;
                    }
                }
            }
        }
    }
}
