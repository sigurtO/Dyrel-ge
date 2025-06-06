﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;

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
                resultTable.Columns.Add("cagePrice", typeof(int));

                if (cageData.Rows.Count == 0 ||
                    cageData.Rows[0]["cageCheck"] == DBNull.Value ||
                    Convert.ToInt32(cageData.Rows[0]["cageCheck"]) == 0)
                {
                    // Add "No Cage" option
                    resultTable.Rows.Add("No Cage", 0); // pretty sure this doesnt work btw
                }
                else
                {
                    // Add actual cage price
                    int price = Convert.ToInt32(cageData.Rows[0]["cagePrice"]);
                    resultTable.Rows.Add($"Cage: {price:C}", treatmentId); // Format as currency
                }

                return resultTable;
            }
            catch (Exception)
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
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DataTable> AddInvoiceAsync(int? treatmentID, int ownerID, int? consultationID, int petID, int? itemID, int? cageID, DateTime date, decimal? discount, decimal totalAmount, decimal netAmount)
        {
            try
            {
                var invoice = new InvoiceClass(treatmentID, ownerID, consultationID, petID, itemID, cageID, date, discount, totalAmount, netAmount);
                await Program.dbServices.DbCreateInvoice.CreateInvoiceAsync(invoice);

                // Return an empty DataTable or a meaningful result if required
                return new DataTable();
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                throw;
            }
        }

        public async Task<int> CalculateTotalAmount( int consultationId, int treatmentId, int cageId, int itemId, int currentTotal)
        {
            int total = currentTotal;

            if (consultationId > 0)
            {
                DataTable consultation = await Program.dbServices.DbReadInvoice.GetConsultationFromPetAsync(consultationId);
                if (consultation.Rows.Count > 0)
                {
                    total += Convert.ToInt32(consultation.Rows[0]["Price"]);
                }
            }

            if (treatmentId > 0)
            {
                DataTable treatment = await Program.dbServices.DbReadInvoice.GetTreatmentFromConsultationAsync(consultationId);
                if (treatment.Rows.Count > 0)
                {
                    total += Convert.ToInt32(treatment.Rows[0]["Price"]);
                }
            }

            if (cageId > 0)
            {
                DataTable cage = await Program.dbServices.DbReadInvoice.CheckCageFromTreatment(cageId);
                if (cage.Rows.Count > 0 && cage.Rows[0]["cagePrice"] != DBNull.Value)
                {
                    total += Convert.ToInt32(cage.Rows[0]["cagePrice"]);
                }
            }

            if (itemId > 0)
            {
                DataTable item = await Program.dbServices.DbReadInvoice.GetAllItemsAsync();
                if (item.Rows.Count > 0)
                {
                    total += Convert.ToInt32(item.Rows[0]["Price"]);
                }
            }

            return total;
        }
    }

}
