using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            List<int> r = nums.Where(n => n % 2 == 0).ToList();

            foreach (var n in r)
            {
                Console.WriteLine(n);
            }
            nums.Add(10);
            Console.WriteLine("--------------");

            foreach (var n in r)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
