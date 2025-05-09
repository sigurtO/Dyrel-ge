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


        public async Task<DataTable> GetOwnerIdFrom()
        {
            string query = @"SELECT OwnerID, FirstName From PetOwner";
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

        //Gets Pets by OwnerID //used in consulation
        public async Task<DataTable> GetPetsByOwnerAsync(int ownerID)
        {

            string query = "SELECT Name, PetID FROM Pet WHERE OwnerID = @OwnerID";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerID", ownerID);
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                dataTable.Load(reader);
            }

            return dataTable;
        }



    }




}
