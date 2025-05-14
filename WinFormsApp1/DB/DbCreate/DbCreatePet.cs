using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbCreate
{
        public class DbCreatePet : Database
        {
            public DbCreatePet(string connectionString) : base(connectionString) { }

         
            public async Task AddPetAsync(PetClass owner)
            {
                string query = "INSERT INTO Pet (OwnerID, PetDocID, Name, Birthday, Species, Breed) VALUES (@OwnerID, @PetDocID, @Name, @Birthday, @Species, @Breed)";
                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OwnerID", owner.OwnerID);
                    command.Parameters.AddWithValue("@PetDocID", owner.PetDocID);
                    command.Parameters.AddWithValue("@Name", owner.Name);
                    command.Parameters.AddWithValue("@Birthday", owner.Birthday);
                    command.Parameters.AddWithValue("@Species", owner.Species);
                    command.Parameters.AddWithValue("@Breed", owner.Breed);
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
}


