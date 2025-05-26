using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DB.DbRead
{
    //Lukas
    public class DbReadOwner : Database
    {

        public DbReadOwner(string connectionString) : base(connectionString) { }

        // Lukas
        public async Task<DataTable> ShowAllOwnersAsync()
        {
            string query = "SELECT * FROM PetOwner";
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
