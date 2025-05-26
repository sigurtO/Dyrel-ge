using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace WinFormsApp1.DB
{

    public abstract class Database
    {

        protected readonly string ConnectionString;

        protected Database(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
