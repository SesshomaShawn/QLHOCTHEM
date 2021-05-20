using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhap
{
    class Connection
    {
        private string connect;
        public Connection()
        {
            connect = @"Data Source=DESKTOP-CQ6U297\SQLEXPRESS;Initial Catalog=QLHOCTHEM;Integrated Security=True";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connect);
        }
    }
}
