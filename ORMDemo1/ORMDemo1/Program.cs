using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities db = new NorthwindEntities();

            Console.WriteLine(db.Categories.GetType().Name);

            foreach (var c in db.Categories)
            {
                //Console.WriteLine(c.GetType().Name);
                foreach (var p in c.Products)
                {
                    //Console.WriteLine("--> " + p.ProductName);
                }
            }

            Console.ReadKey();
        }
    }
}
