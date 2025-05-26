using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DB.DbRead
{
    //Tolu
    public class DbReadPet : Database
    {

        public DbReadPet(string connectionString) : base(connectionString) { }


        public async Task<DataTable> ShowAllPetAsync()
        {
            string query = "SELECT * FROM Pet";
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


        public async Task<DataTable> GetOwnersAsync() // we use Datatable becuase we are getting mutiple rows of information from the DB
        {
            string query = "SELECT OwnerID, FirstName from PetOwner";
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

        public async Task<DataTable> GetAllVetsAsync()
        {
            string query = "SELECT PetDocID, FirstName from PetDoc";
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

