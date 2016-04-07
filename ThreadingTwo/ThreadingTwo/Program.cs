using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide a value for n: ");
            int n = int.Parse(Console.ReadLine());

            Task<BigInteger> task = new Task<BigInteger>(() => Sum(n));
            task.Start();

            Console.WriteLine(task.Result);
            Console.ReadKey();
        }

        static BigInteger Sum(int n)
        {
            BigInteger retVal = 0;
            while (n > 0)
            {
                retVal += n;
                n--;
            }
            return retVal;
        }
    }
}
