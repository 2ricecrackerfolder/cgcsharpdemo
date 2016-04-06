using NW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Data
{
    public class Repository
    {
        public IEnumerable<Category> GetAllCategories()
        {
            var retVal = new List<Category>();
            retVal.Add(new Category(1) { CategoryName = "Laptop", Description = "Computer" });
            retVal.Add(new Category(2) { CategoryName = "Fruit", Description = "Apple" });
            return retVal;
        }
    }
}
