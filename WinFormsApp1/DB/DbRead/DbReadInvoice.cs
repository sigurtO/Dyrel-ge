using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DB.DbRead
{
    public class DbReadInvoice : Database
    {
        public DbReadInvoice(string connectionString) : base(connectionString) { }


        public async Task<DataTable> GetAllInvoicesAsync()
        {
            string query = "Select * from Invoice";

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                dataTable.Load(reader);
            }
            return dataTable;
        }

    }
}
