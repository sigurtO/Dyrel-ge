using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DB.DbDelete
{
    //Daniel
    public class DbDeleteTreatment : Database
    {
        public DbDeleteTreatment(string connectionString) : base(connectionString) { }


        public async Task DeleteTreatmentByIdAsync(int TreatmentId)
        {
            string query = "DELETE FROM Treatment WHERE TreatmentID = @TreatmentId";



            using (SqlConnection connection = CreateConnection())
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TreatmentId", TreatmentId);

                await command.ExecuteNonQueryAsync();

            }
        }
    }
}
