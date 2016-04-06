using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Models
{
    public class Product
    {
        public Product() { }

        public Product(int pid)
        {
            ProductID = pid;
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}
