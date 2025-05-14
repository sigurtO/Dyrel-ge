using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1.Service
{
    public class TreatmentService : ITreatmentService, IOwnerRelated
    {
        public async Task<DataTable> LoadTreatmentDataAsync()
        {
            try
            {
                return await Program.dbServices.DbReadTreatment.ShowAllTreatmentsAsync();
            } //Program.DbReadTreatment.ShowAllTreatmentsAsync();
            catch (Exception ex)
            {
                throw new TreatmentServiceException("Failed to load Treatments", ex);
            }
        }

        public async Task<DataTable> LoadOwnersAsync()     // load owners into ComboBOx
        {
            try
            {
                DataTable owners = await Program.dbServices.DbReadTreatment.GetOwnersAsync();

                DataRow newRow = owners.NewRow();
                newRow["OwnerID"] = 0;
                newRow["FirstName"] = "-- Select Owner --";
                owners.Rows.InsertAt(newRow, 0);

                return owners;
            }
            catch (Exception ex)
            {
                throw new TreatmentServiceException("Failed to load owners", ex);
            }
        }
        public async Task<DataTable> LoadOwnerDataAsync()     // load owners into ComboBOx
        {
            try
            {
                DataTable owners = await Program.dbServices.DbReadTreatment.GetOwnersAsync();

                DataRow newRow = owners.NewRow();
                newRow["OwnerID"] = 0;
                newRow["FirstName"] = "-- Select Owner --";
                owners.Rows.InsertAt(newRow, 0);

                return owners;
            }
            catch (Exception ex)
            {
                throw new TreatmentServiceException("Failed to load owners", ex);
            }
        }
        public async Task<DataTable> GetPetsByOwnerAsync(int ownerId)
        {
            if (ownerId <= 0) return null;
            try
            {
                return await Program.dbServices.DbReadTreatment.GetPetsByOwnerAsync(ownerId);
            }
            catch (Exception ex)
            {
                throw new TreatmentServiceException($"Failed to load pets for owner {ownerId}", ex);
            }

        }

        public async Task<DataTable> GetVeterinariansByPetAsync(int petId)
        {
            if (petId <= 0) return null;
            try
            {
                return await Program.dbServices.DbReadTreatment.GetVeterinariansByPetAsync(petId);
            }
            catch (Exception ex)
            {
                throw new TreatmentServiceException($"Failed to load vets for pet {petId}", ex);
            }
        }

        //HandleAddTreatmentAsync
        public async Task AddTreatmentAsync(int ownerId, int petDocId, int consultationId, int price, DateTime date, string notes, int petID)
        {
            try
            {
                var treatment = new TreatmentClass(ownerId, petDocId, consultationId, price, date, notes, petID);
                await Program.dbServices.DbCreateTreatment.CreateTreatmentAsync(treatment);
            }
            catch (Exception ex)
            {
                throw new TreatmentServiceException("Failed to add treatment", ex);
            }
        }

        public async Task DeleteTreatmentAsync(int treatmentId)
        {
            try
            {
                await Program.dbServices.DbDeleteTreatment.DeleteTreatmentByIdAsync(treatmentId);
            }
            catch (Exception ex)
            {
                throw new TreatmentServiceException($"Failed to delete treatment {treatmentId}", ex);
            }
        }

        public async Task UpdateTreatmentAsync(TreatmentClass treatment, int treatmentId)
        {
            try
            {
                await Program.dbServices.DbUpdateTreatment.UpdateTreatmentAsync(treatment, treatmentId);
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException($"Failed to update consultation {treatmentId}", ex);
            }
        }
    }
}
public class TreatmentServiceException : Exception
{
    public TreatmentServiceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}