using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO
{
    class GenericList<TValue>
    {
        public TValue value;

        public GenericList(TValue _value)
        {
            value = _value;
        }

        public void Print() {
            Console.WriteLine("Value:" + value.ToString());
        }
    }
}
