﻿using NW.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Data
{
    internal class Repository : IRepository
    {
        private string connStr;

        public Repository(string connStr)
        {
            this.connStr = connStr;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var retVal = new List<Category>();

            SqlConnection conn = new SqlConnection(connStr);
            string sql = "SELECT * FROM Categories";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    using (rdr)
                    {
                        while (rdr.Read())
                        {
                            retVal.Add(
                                new Category((int)rdr["CategoryID"])
                                {
                                    CategoryName = (string)rdr["CategoryName"],
                                    Description = (string)rdr["Description"],
                                    Picture = (byte[])rdr["Picture"]
                                });
                        }
                    }
                }
 
            } catch (Exception ex)
            {
                // log it
                // notification
                throw new ApplicationException("Bad Things", ex);
            }
            return retVal;
        }
    }
}
