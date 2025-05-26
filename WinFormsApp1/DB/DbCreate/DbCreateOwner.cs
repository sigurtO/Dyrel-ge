using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbCreate
{
    //Lukas
    public class DbCreateOwner : Database
    {
        public DbCreateOwner(string connectionString) : base(connectionString) { }

     
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
        public async Task AddOwnerWithEFCAsync(OwnerClass owner)
        {
            try
            {
                using (var context = new WinformDbContext(ConnectionString))
                {
                    context.PetOwners.Add(owner);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Database error while adding owner: {ex.Message}", ex);
            }
        }

    }
}
