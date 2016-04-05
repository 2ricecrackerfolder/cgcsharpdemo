using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;
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

    enum TempScale
    {
        F, C, K
    }

    struct Temperature
    {
        public float value;
        public TempScale scale;
    }

    class Program
    {
        static Temperature Convert(Temperature t, TempScale scale)
        {
            Temperature rv;
            rv.value = 32;
            rv.scale = TempScale.F;
            return rv;
        }

        static void Main(string[] args)
        {
            bool? i = null;

            bool a = i.GetValueOrDefault();

            Console.WriteLine(a);

            Console.ReadKey();
        }

        static int Foo(object obj)
        {
            return 0;
        }
    }

    enum EmpType
    {
        Unknown,
        Manager,
        Grunt,
        Contractor
    }

}
