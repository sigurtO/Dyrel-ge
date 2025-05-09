using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbCreate
{
    public class DbCreateConsultation : Database
    {
        public DbCreateConsultation(string connectionString) : base(connectionString) { }


        public async Task CreateConsultationAsync(ConsultationClass consultation)
        {
            string query = "INSERT INTO Consultation (OwnerID, PetID, PetDocID, Date, Notes, Price) VALUES (@OwnerID, @PetID, @PetDocID, @Date, @Notes, @Price)";
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerID", consultation.OwnerID);
                command.Parameters.AddWithValue("@PetID", consultation.PetID);
                command.Parameters.AddWithValue("@PetDocID", consultation.VetID);
                command.Parameters.AddWithValue("@Date", consultation.Date);
                command.Parameters.AddWithValue("@Notes", consultation.Notes);
                command.Parameters.AddWithValue("@Price", consultation.Price);
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
