using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbCreate
{
    public class DbCreateTreatment : Database
    {
        public DbCreateTreatment(string connectionString) : base(connectionString) { }
        public async Task CreateTreatmentAsync(TreatmentClass treatment)
        {
            string query = "INSERT INTO Treatment (OwnerID, PetDocID, ConsultationID, Notes, Price) VALUES (@OwnerID, @PetDocID, @ConsultationID, @Notes, @Price)";
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerID", treatment.OwnerID);
                command.Parameters.AddWithValue("@PetDocID", treatment.PetDocID);
                command.Parameters.AddWithValue("@ConsultationID", treatment.ConsultationID);
                command.Parameters.AddWithValue("@Notes", treatment.Notes);
                command.Parameters.AddWithValue("@Price", treatment.Price);
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
        //Gets Owners
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
    }
}
