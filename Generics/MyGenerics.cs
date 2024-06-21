using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyGenerics<T>
    {
        public T[] values;
        public MyGenerics()
        {
            values = Array.Empty<T>();
           
        }
        public void Add(T item)
        {
            T[] saveData = values;
            values = new T[values.Length+1];

            for (int i = 0; i < saveData.Length; i++)
            {
                values[i] = saveData[i];
            }
            values[^1] = item;
        }

    }
}
