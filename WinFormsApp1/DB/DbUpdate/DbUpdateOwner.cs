using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbUpdate
{
    //Lukas
    public class DbUpdateOwner : Database
    {

        public DbUpdateOwner(string connectionString) : base(connectionString) { }


        public async Task UpdateOwnerAsync(OwnerClass owner, int ownerId)
        {
            string query = @"UPDATE PetOwner SET FirstName=@FirstName,
                            LastName=@LastName,
                            Phone=@Phone, 
                            Email=@Email,
                            Adress=@Adress
                            WHERE OwnerID=@OwnerID";
            using (SqlConnection connection = CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", owner.FirstName);
                command.Parameters.AddWithValue("@LastName", owner.LastName);
                command.Parameters.AddWithValue("@Phone", owner.Phone);
                command.Parameters.AddWithValue("@Email", owner.Email);
                command.Parameters.AddWithValue("@Adress", owner.Adress);
                command.Parameters.AddWithValue("@OwnerID", ownerId);

                await connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected == 0)
                    throw new Exception("No rows updated. OwnerID may not exist.");
            }
        }

    }
}

