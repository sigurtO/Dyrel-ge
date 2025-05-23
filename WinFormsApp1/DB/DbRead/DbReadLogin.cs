using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DB;


public class DbReadLogin : Database
{
    public DbReadLogin(string connectionString) : base(connectionString) { }
    9
    public async Task<string?> GetPasswordHashByUsernameAsync(string username)
    {
        const string query = @"SELECT Password FROM PetDoc WHERE Username = @Username";

        using (SqlConnection connection = CreateConnection())
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Username", username);
            await connection.OpenAsync();
            object result = await command.ExecuteScalarAsync();
            return result is DBNull or null ? null : result.ToString();
        }
    }
}
