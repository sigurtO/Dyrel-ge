using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Interfaces
{
    public interface IConsultationService // rework interfaces so all interfaces are in one cs file.
    {
        Task<DataTable> LoadConsultationDataAsync();
        Task<DataTable> LoadOwnersAsync();
        Task<DataTable> GetPetsByOwnerAsync(int ownerId);
        Task<DataTable> GetVeterinariansByPetAsync(int petId);
        Task AddConsultationAsync(int ownerId, int petId, int vetId, DateTime date, int price, string notes);
        Task DeleteConsultationAsync(int consultationId);
    }


    
    public interface ITreatmentService
    {
        Task<DataTable> LoadTreatmentDataAsync();
        Task<DataTable> LoadOwnersAsync();
        Task<DataTable> GetPetsByOwnerAsync(int ownerId);
        Task<DataTable> GetVeterinariansByPetAsync(int petId);
        Task AddTreatmentAsync(int ownerId, int petDocId, int consultationId, int price, DateTime date, string notes, int petID);
        Task DeleteTreatmentAsync(int consultationId);
    }
    


    //public interface IOwnerService
    //{

    //}



}
