using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbUpdate
{
    public class DbUpdateConsultation : Database
    {

        public DbUpdateConsultation(string connectionString) : base(connectionString) { } // constructor passes the connection string to the base class



        public async Task UpdateConsultationAsync(ConsultationClass consultation, int consultationId)
        {
            string query = @"UPDATE Consultation 
                    SET OwnerID = @OwnerID, 
                        PetID = @PetID, 
                        PetDocID = @PetDocID, 
                        Date = @Date, 
                        Notes = @Notes, 
                        Price = @Price
                    WHERE ConsultationID = @ConsultationID";

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ConsultationID", consultationId);
                command.Parameters.AddWithValue("@OwnerID", consultation.OwnerID);
                command.Parameters.AddWithValue("@PetID", consultation.PetID);
                command.Parameters.AddWithValue("@PetDocID", consultation.VetID);
                command.Parameters.AddWithValue("@Date", consultation.Date);
                command.Parameters.AddWithValue("@Notes", consultation.Notes);
                command.Parameters.AddWithValue("@Price", consultation.Price);

                await connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();

                if (rowsAffected == 0)
                {
                    throw new Exception("No consultation was updated. Record may not exist.");
                }
            }
        }




    }
}
