using System.Collections.Generic;
using NW.Models;

namespace NW.Data
{
    public interface IRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}