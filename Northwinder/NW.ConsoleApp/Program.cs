using NW.Data;
using NW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository r = new Repository();
            var categories = r.GetAllCategories();
            foreach (Category c in categories)
            {
                Console.WriteLine(c.CategoryName);
            }
            Console.ReadKey();
        }
    }
}
