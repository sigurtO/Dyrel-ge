using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinFormsApp1.DB;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class ConsultationService : IConsultationService, IOwnerRelated, IVetinarianRelated
    {
  
        //private readonly DbService _dbService;

        //public ConsultationService(DbService dbService)
        //{
        //    _dbService = dbService;
        //}

        public async Task<DataTable> LoadConsultationDataAsync()
        {
            try
            {
                return await Program.dbServices.DbReadConsultation.ShowAllConsultationsAsync();
            } //Program.DbReadConsultation.ShowAllConsultationsAsync();
            catch (Exception ex)
            {
                throw new ConsultationServiceException("Failed to load consultations", ex);
            }

         
        }

        public async Task<DataTable> LoadOwnerDataAsync()     // load owners into ComboBOx
        {
            try
            {
                DataTable owners = await Program.dbServices.DbReadConsultation.GetOwnersAsync();

                DataRow newRow = owners.NewRow();
                newRow["OwnerID"] = 0;
                newRow["FirstName"] = "-- Select Owner --";
                owners.Rows.InsertAt(newRow, 0);

                return owners;
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException("Failed to load owners", ex);
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
                throw new ConsultationServiceException($"Failed to load pets for owner {ownerId}", ex);
            }

        }

        public async Task<DataTable> GetVeterinariansByPetAsync(int petId)
        {
            if ( petId <= 0) return null;
            try
            {
                return await Program.dbServices.DbReadConsultation.GetVeterinariansByPetAsync(petId);
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException($"Failed to load vets for pet {petId}", ex);
            }
        }

        //HandleAddConsultationAsync
        public async Task AddConsultationAsync(int ownerId, int petId, int vetId, DateTime date, int price, string notes)
        {
            try
            {
                var consultation = new ConsultationClass(ownerId, petId, vetId, date, price, notes);
                await Program.dbServices.DbCreateConsultation.CreateConsultationAsync(consultation);

            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException("Failed to add consultation", ex);
            }
        }

        public async Task DeleteConsultationAsync(int consultationId)
        {
            try
            {
                await Program.dbServices.DbDeleteConsultation.DeleteConsultationByIdAsync(consultationId);
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException($"Failed to delete consultation {consultationId}", ex);
            }
        }

        public async Task UpdateConsultationAsync(ConsultationClass consultation, int consultationId)
        {
            try
            {
                await Program.dbServices.DbUpdateConsultation.UpdateConsultationAsync(consultation, consultationId);
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException($"Failed to update consultation {consultationId}", ex);
            }
        }


    }

}

// Custom exception class
public class ConsultationServiceException : Exception
{
    public ConsultationServiceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}