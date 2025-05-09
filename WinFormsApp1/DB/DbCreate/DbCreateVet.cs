using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbCreate
{
    public class DbCreateVet : Database
    {
        public DbCreateVet(string connectionString) : base(connectionString) { }
        //emil
        public async Task CreateVetAsync(VetClass vet)
        {
            string query = @"INSERT INTO PetDoc 
                    (FirstName, LastName, Username, Password, Speciale) 
                    VALUES (@FirstName, @LastName, @Username, @Password, @Speciale)";

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", vet.FirstName);
                command.Parameters.AddWithValue("@LastName", vet.LastName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Username", vet.Username);
                command.Parameters.AddWithValue("@Password", vet.PasswordHash);
                command.Parameters.AddWithValue("@Speciale", vet.Speciale ?? (object)DBNull.Value);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }

        }
    }
}
