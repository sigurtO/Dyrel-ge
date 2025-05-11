using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DB.DbRead //HAVE TO ADD DELETE TO INVOICE OR YOU CANT DELETE CONSULTATION
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

        //Get owners and GetPetsByOwnerAsync are the same as in DbReadConsultation so we just call it there instead :)

        public async Task<DataTable> GetConsultationFromPetAsync(int PetID) 
        {
            string query = "SELECT Notes, Price, ConsultationID FROM Consultation WHERE PetID = @PetID"; // maybe also get date?? 
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PetID", PetID);
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public async Task<DataTable> GetTreatmentFromConsultationAsync(int consultationID)
        {
            string query = "SELECT Notes, Price, TreatmentID FROM Treatment WHERE ConsultationID = @ConsultationID";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ConsultationID", consultationID);
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public async Task<DataTable>  CheckCageFromTreatment(int treatmentID)
        {
            string query = "SELECT cageCheck, cagePrice FROM Treatment WHERE TreatmentID = @TreatmentID"; //if null
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TreatmentID", treatmentID);
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public async Task<DataTable> GetAllItemsAsync()
        {
            string query = "SELECT ItemID, Name FROM Item";
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
