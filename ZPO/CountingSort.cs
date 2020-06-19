using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZPO
{
    public class CountingSort<T> : ISortMetod<T>
        where T : IComparable<T>
    {
        public void Sort(IList<T> array)
        {
            List<T> coppy = new List<T>(array);
            cs(array);
        }
        public static void cs<T>(IList<T> array)
        {
           /*.... */
        }
    }
}
