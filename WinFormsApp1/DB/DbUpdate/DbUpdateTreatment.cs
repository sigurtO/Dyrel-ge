using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbUpdate
{
    public class DbUpdateTreatment : Database
    {

        public DbUpdateTreatment(string connectionString) : base(connectionString) { } // constructor passes the connection string to the base class



        public async Task UpdateTreatmentAsync(TreatmentClass treatment, int treatmentId)
        {
            string query = @"UPDATE Treatment 
                    SET OwnerID = @OwnerID,  
                        PetDocID = @PetDocID,
                        PetID = @PetID,
                        ConsultationID = @ConsultationID,
                        Price = @Price,
                        Date = @Date, 
                        Notes = @Notes,
                        
                    WHERE TreatmentID = @TreatmentID"; // Assuming you have a primary key

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ConsultationID", treatmentId);
                command.Parameters.AddWithValue("@OwnerID", treatment.OwnerID);
                command.Parameters.AddWithValue("@PetDocID", treatment.PetDocID);
                command.Parameters.AddWithValue("@PetID", treatment.PetID);
                command.Parameters.AddWithValue("@ConsultationID", treatment.ConsultationID);
                command.Parameters.AddWithValue("@Price", treatment.Price);
                command.Parameters.AddWithValue("@Date", treatment.Date);
                command.Parameters.AddWithValue("@Notes", treatment.Notes);

                await connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();

                if (rowsAffected == 0)
                {
                    throw new Exception("No treatment was updated. Record may not exist.");
                }
            }
        }
    }
}
