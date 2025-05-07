using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB
{
    public class DbCreate : Database
    {
        public DbCreate(string connectionString) : base(connectionString) { }


        public async Task CreateConsultationAsync(ConsultationClass consultation)
        {
            string query = "INSERT INTO Consultation (OwnerID, PetID, PetDocID, Date, Notes, Price) VALUES (@OwnerID, @PetID, @PetDocID, @Date, @Notes, @Price)";
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerID", consultation.OwnerID);
                command.Parameters.AddWithValue("@PetID", consultation.PetID);
                command.Parameters.AddWithValue("@PetDocID", consultation.VetID);
                command.Parameters.AddWithValue("@Date", consultation.Date);
                command.Parameters.AddWithValue("@Notes", consultation.Notes);
                command.Parameters.AddWithValue("@Price", consultation.Price);
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
        public async Task CreateVetAsync(VetClass vet)
        {
            string query = "INSERT INTO PetDoc (FirstName) VALUES (@FirstName)";
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", vet.FirstName);
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
        public async Task AddOwnerAsync(OwnerClass owner)
        {
            string query = "INSERT INTO PetOwner (FirstName, LastName, Phone, Email, Adress) VALUES (@FirstName, @LastName, @Phone, @Email, @Adress)";
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", owner.FirstName);
                command.Parameters.AddWithValue("@LastName", owner.LastName);
                command.Parameters.AddWithValue("@Phone", owner.PhoneNumber);
                command.Parameters.AddWithValue("@Email", owner.Email);
                command.Parameters.AddWithValue("@Adress", owner.Adress);
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
