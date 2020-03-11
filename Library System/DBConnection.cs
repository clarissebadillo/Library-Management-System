using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=LAPTOP-PM36MAJR;Initial Catalog=LIBDB;Integrated Security=True";
            return con;
        }
    }
}
