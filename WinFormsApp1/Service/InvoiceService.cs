using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Service
{
    public class InvoiceService : IInvoiceService, IOwnerRelated
    {
        public async Task<DataTable> LoadInvoiceAsync()
        {
			try
			{
                DataTable Invoice = await Program.dbServices.DbReadInvoice.GetAllInvoicesAsync();
                return Invoice;
            }
			catch (Exception)
			{

				throw;
			}
        }

        public async Task<DataTable> LoadOwnerDataAsync()   //From interface because single responsibility principle
        {
            try
            {
                DataTable owners = await Program.dbServices.DbReadConsultation.GetOwnersAsync(); //exactly the same so we can use the same method
                                                                                                //technically we aren't using single responsibility principle BUUUUUT. we also only split DB up to make it cleaner
                DataRow newRow = owners.NewRow();
                newRow["OwnerID"] = 0;
                newRow["FirstName"] = "-- Select Owner --";
                owners.Rows.InsertAt(newRow, 0);

                return owners;
            }
            catch (Exception ex)
            {
                throw;
                //throw new ConsultationServiceException("Failed to load owners", ex);
            }
        }

        public async Task<DataTable> GetPetsByOwnerAsync(int ownerId)
        {
            if (ownerId <= 0) return null;
            try
            {
                return await Program.dbServices.DbReadConsultation.GetPetsByOwnerAsync(ownerId);
            }
            catch (Exception ex)
            {
                throw;
                //throw new ConsultationServiceException($"Failed to load pets for owner {ownerId}", ex);
            }

        }


        //GetConsultationFromOwnerAsync

        public async Task<DataTable> GetConsultationFromPetDataAsync(int petId)
        {
            try
            {
                return await Program.dbServices.DbReadInvoice.GetConsultationFromPetAsync(petId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DataTable> GetTreatmentFromConsultationDataAsync(int consultationId)
        {
            try
            {
                return await Program.dbServices.DbReadInvoice.GetTreatmentFromConsultationAsync(consultationId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DataTable> CheckCageFromTreatmentDataAsync(int treatmentId)
        {
            try
            {
                DataTable cageData = await Program.dbServices.DbReadInvoice.CheckCageFromTreatment(treatmentId);

                // Create a new DataTable with just the columns we need
                DataTable resultTable = new DataTable();
                resultTable.Columns.Add("DisplayText", typeof(string));  // What will be shown in combobox
                resultTable.Columns.Add("CageID", typeof(int));          // The value member
                resultTable.Columns.Add("cagePrice", typeof(int)); // Add this!

                if (cageData.Rows.Count == 0 ||
                    cageData.Rows[0]["cageCheck"] == DBNull.Value ||
                    Convert.ToInt32(cageData.Rows[0]["cageCheck"]) == 0)
                {
                    // Add "No Cage" option
                    resultTable.Rows.Add("No Cage", 0);
                }
                else
                {
                    // Add actual cage price
                    int price = Convert.ToInt32(cageData.Rows[0]["cagePrice"]);
                    resultTable.Rows.Add($"Cage: {price:C}", treatmentId); // Format as currency
                }

                return resultTable;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<DataTable> GetAllItemsDataAsync()
        {
            try
            {
                return await Program.dbServices.DbReadInvoice.GetAllItemsAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //public async Task<DataTable> GetItemAndPriceDataAsync(int itemId)
        //{
        //    try
        //    {
        //        return await Program.dbServices.DbReadInvoice.GetItemAndPriceAsync(itemId);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}




    }
}
