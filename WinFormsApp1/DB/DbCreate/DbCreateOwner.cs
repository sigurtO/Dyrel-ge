using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbCreate
{
    public class DbCreateOwner : Database
    {
        public DbCreateOwner(string connectionString) : base(connectionString) { }

        //Lukas
        public async Task AddOwnerAsync(OwnerClass owner)
        {
            string query = "INSERT INTO PetOwner (FirstName, LastName, Phone, Email, Adress) VALUES (@FirstName, @LastName, @Phone, @Email, @Adress)";
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", owner.FirstName);
                command.Parameters.AddWithValue("@LastName", owner.LastName);
                command.Parameters.AddWithValue("@Phone", owner.Phone);
                command.Parameters.AddWithValue("@Email", owner.Email);
                command.Parameters.AddWithValue("@Adress", owner.Adress);
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
