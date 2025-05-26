using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;
using static WinFormsApp1.Objects.InvoiceClass;

namespace WinFormsApp1.DB.DbCreate
{
    //Emil
    public class DbCreateInvoice : Database
    {
        public DbCreateInvoice(string connectionString) : base(connectionString) { }

        public async Task CreateInvoiceAsync(InvoiceClass invoice)
        {
            string query = @"INSERT INTO Invoice 
                            (OwnerID, ConsultationID, PetID, Date, TotalAmount, NetAmount,
                            TreatmentID, ItemID, Discount) 
                            VALUES 
                            (@OwnerID, @ConsultationID, @PetID, @Date, @TotalAmount, @NetAmount,
                                @TreatmentID, @ItemID, @Discount)";

            using (SqlConnection connection = CreateConnection())
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(query, connection);

                
                command.Parameters.AddWithValue("@OwnerID", invoice.OwnerID);
                command.Parameters.AddWithValue("@ConsultationID", invoice.ConsultationID);
                command.Parameters.AddWithValue("@PetID", invoice.PetID);
                command.Parameters.AddWithValue("@Date", invoice.Date);
                command.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
                command.Parameters.AddWithValue("@NetAmount", invoice.NetAmount);

                // Parameters with NULL handling
                command.Parameters.Add("@TreatmentID", SqlDbType.Int).Value = 
                    invoice.TreatmentID ?? (object)DBNull.Value;
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value =
                    invoice.ItemID ?? (object)DBNull.Value;
                command.Parameters.Add("@CageID", SqlDbType.Int).Value =
                    invoice.CageID ?? (object)DBNull.Value;
                command.Parameters.Add("@Discount", SqlDbType.Decimal).Value =
                    invoice.Discount ?? (object)DBNull.Value; // ?? is an if statement if has value use X otherwise use Y

                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
