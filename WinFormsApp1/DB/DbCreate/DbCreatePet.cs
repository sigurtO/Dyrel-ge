using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbCreate
{
    //Tolu
        public class DbCreatePet : Database
        {
            public DbCreatePet(string connectionString) : base(connectionString) { }

         
            public async Task AddPetAsync(PetClass pet)
            {
                string query = "INSERT INTO Pet (OwnerID, PetDocID, Name, Birthday, Species, Breed) VALUES (@OwnerID, @PetDocID, @Name, @Birthday, @Species, @Breed)";
                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OwnerID", pet.OwnerID);
                    command.Parameters.AddWithValue("@PetDocID", pet.PetDocID);
                    command.Parameters.AddWithValue("@Name", pet.Name);
                    command.Parameters.AddWithValue("@Birthday", pet.Birthday);
                    command.Parameters.AddWithValue("@Species", pet.Species);
                    command.Parameters.AddWithValue("@Breed", pet.Breed);
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
}


