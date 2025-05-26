using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DB.DbDelete
{
    public class DbDeleteConsultation : Database
    {
        public DbDeleteConsultation(string connectionString) : base(connectionString) { }


        public async Task DeleteConsultationByIdAsync(int ConsultationId)
        {
            string query = "DELETE FROM Consultation WHERE ConsultationID = @ConsultationId";



            using (SqlConnection connection = CreateConnection())
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ConsultationId", ConsultationId);

                await command.ExecuteNonQueryAsync();

            }
        }
    }
}
