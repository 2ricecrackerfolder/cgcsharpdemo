using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp
{
    public class Employee : Person
    {
        public Decimal Salary { get; set; }

        public Employee()
            : this("", "") { }

        public Employee(string fn, string ln)
            : base(fn, ln)
        {
            Salary = 0;
        }

        public new string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
