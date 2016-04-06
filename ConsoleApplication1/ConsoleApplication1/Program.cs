using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exts;

namespace ConsoleApplication1
{
    public class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { Name = "Bill" },
                new Person { Name = "Steve"},
                new Person {  Name = "Bob"}
            };
            
            var r = people.Where(delegate(Person p) {
                return p.Name.StartsWith("B"); } );
        
            foreach (var p in r)
            {
                Console.WriteLine(p.Name);
            }

            Console.ReadKey();
        }

        static bool IsMatch(Person p)
        {
            return p.Name.StartsWith("B");
        }
    }
}
