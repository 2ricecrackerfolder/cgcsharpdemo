using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exts
{
    public static class MyExtensions
    {
        public static int DoubleIt(this int a)
        {
            return a * 2;
        }
    }
}
