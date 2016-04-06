using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp
{
    public class Foo
    {
        int a = 1;
        int b;

        public Foo()
        {
            b = 2;
        }
    }

    public class Bar : Foo
    {
        int c = 3;
        int d;

        public Bar()
        {
            d = 4;
        }
    }


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
            : this("", "") { }

        public Person(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public override string ToString()
        {
            return FullName;
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
            List<Person> people = new List<Person>();
            people.Add(new Person("Bill", "Gates"));
            people.Add(new Employee("Steve", "Jobs"));

            foreach(var p in people)
            {
                if (p is Employee)
                {
                    Console.WriteLine((p as Employee).FullName);
                }
                else
                {
                    Console.WriteLine(p.FullName);
                }
            }

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
