using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Data
{
    public static class RepositoryFactory
    {
        public static IRepository GetRepository(string connStr)
        {
            //return new Repository(connStr);
            return new EFRepository(connStr);
        }
    }
}
