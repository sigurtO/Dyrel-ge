using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbRead
{
    public class DbReadVet : Database
    {
        public DbReadVet(string connectionString) : base(connectionString) { }

        // retarded emil
        public async Task<DataTable> GetAllVetsAsync()
        {
            string query = @"SELECT 
                    PetDocID, 
                    FirstName, 
                    LastName, 
                    Username, 
                    Speciale,
                    CASE WHEN Password IS NULL THEN 'No' ELSE 'Yes' END AS HasPassword
                    FROM PetDoc";
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

        public async Task<VetClass> AuthenticateVetAsync(string username, string password)
        {
            string query = "SELECT PetDocID, FirstName, LastName, Username, Password, Speciale FROM PetDoc WHERE Username = @Username";

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                await connection.OpenAsync();
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        string storedHash = reader["PasswordHash"].ToString();
                        if (PasswordHelper.VerifyPassword(password, storedHash))
                        {
                            return new VetClass(
                                (int)reader["PetDocID"],
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString(),
                                reader["Username"].ToString(),
                                storedHash,
                                reader["Thesis"]?.ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }
    }
}
