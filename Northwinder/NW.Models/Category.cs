using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Models
{
    public class Category
    {
        public Category() { }

        public Category(int catID)
        {
            CategoryID = catID;
        }

        public int CategoryID { get; private set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
