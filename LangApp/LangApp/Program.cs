using System;
using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //var p1 = new Person() { LastName = "J", FirstName = "B" };
            //var p2 = p1;// new Person() { LastName = "J", FirstName = "B" };

            //object.ReferenceEquals(p1, p2);

            //Console.WriteLine((p1 == p2) ? "Yes" : "No");

            string a = null;
            string b = String.Empty;
            Person c = null;

            Console.WriteLine(object.ReferenceEquals(a, c) ? "Yes" : "No");

            Console.ReadKey();
        }

        static void Foo(ref string s)
        {
            s = s.ToUpper();
        }

       
    }
}
