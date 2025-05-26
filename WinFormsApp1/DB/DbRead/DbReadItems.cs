using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DB.DbRead
{
    //Sigurt
    public class DbReadItems : Database
    {

        public DbReadItems(string connectionString) : base(connectionString) { }


        public async Task<DataTable> GetAllItems()
        {
            string query = "Select * from Item";

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
