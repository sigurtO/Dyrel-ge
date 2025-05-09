using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.DB.DbRead
{
    public class DbReadConsultation : Database
    {

        public DbReadConsultation(string connectionString) : base(connectionString) { } // constructor passes the connection string to the base class

        //God like Sigurt

        //This method is used to get all consultations from the database into our datagridview
        public async Task<DataTable> ShowAllConsultationsAsync() // we use Datatable becuase we are getting mutiple rows of information from the DB
        {
            string query = "SELECT * FROM Consultation";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = CreateConnection()) //Create connection is from the base class
            {
                SqlCommand command = new SqlCommand(query, connection);
                await connection.OpenAsync(); // we use OpenAsync instead of Open() when there's an await
                SqlDataReader reader = await command.ExecuteReaderAsync();
                dataTable.Load(reader);
            }

            return dataTable;
        }


        //Gets Owners
        public async Task<DataTable> GetOwnersAsync() // we use Datatable becuase we are getting mutiple rows of information from the DB
        {
            string query = "SELECT OwnerID, FirstName from PetOwner";
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

        //Gets Pets by OwnerID //used in consulation
        public async Task<DataTable> GetPetsByOwnerAsync(int ownerID)
        {

            string query = "SELECT Name, PetID FROM Pet WHERE OwnerID = @OwnerID";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection); 
                command.Parameters.AddWithValue("@OwnerID", ownerID);
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                dataTable.Load(reader);
            }

            return dataTable;
        }





        //Gets Veterinarians by Pet
        public async Task<DataTable> GetVeterinariansByPetAsync(int? petID) // Nullable int to allow for no petID
        {
            string query;
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command;

                if (petID.HasValue)
                {
                    // If petDocID is null in Pet (get all) else Only get the assigned DOC
                    query =
                       @" DECLARE @PetHasDocID INT = (SELECT PetDocID FROM Pet WHERE PetID = @PetID);
                            
                            IF @PetHasDocID IS NULL
                             SELECT FirstName, PetDocID FROM PetDoc;
                         ELSE
                            SELECT FirstName, PetDocID FROM PetDoc 
                            WHERE PetDocID = @PetHasDocID;";



                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PetID", petID.Value);
                }
                else
                {
                    // If no petID provided, return all veterinarians
                    query = "SELECT FirstName, PetDocID FROM PetDoc";
                    command = new SqlCommand(query, connection);
                }

                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                dataTable.Load(reader);
            }

            return dataTable;
        }

       
    }
}