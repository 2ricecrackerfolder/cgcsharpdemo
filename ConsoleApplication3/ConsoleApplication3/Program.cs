using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine(GenGreeting(name));

            Console.ReadKey();
        }

        static string GenGreeting(string name)
        {
            return "Hello, " + name;
        }
    }
}
