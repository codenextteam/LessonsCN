using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Calculate
    {

        public int Plus(out int a, int b)
        {
            a = 40;
            return a + b;
        }
    }
}
