using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Interfaces
{
    public interface IConsultationService
    {
        Task<DataTable> LoadConsultationDataAsync();
        Task<DataTable> GetVeterinariansByPetAsync(int petId);
        Task AddConsultationAsync(int ownerId, int petId, int vetId, DateTime date, int price, string notes);
        Task DeleteConsultationAsync(int consultationId);
    }


    public interface IOwnerRelated // multiple services will use this one interface
    {
        Task<DataTable> LoadOwnerDataAsync();
        Task<DataTable> GetPetsByOwnerAsync(int ownerId);

    }


    public interface IInvoiceService
    {
        Task<DataTable> LoadInvoiceAsync(); 
        Task<DataTable> GetConsultationFromPetDataAsync(int ownerId);
        Task<DataTable> GetTreatmentFromConsultationDataAsync(int consultationId);
        Task<DataTable> CheckCageFromTreatmentDataAsync(int treatmentId);

        Task<DataTable> GetAllItemsDataAsync();
        Task<int> CalculateTotalAmount(int ownerId, int consultationId, int treatmentId, int cageId, int itemId, int currentTotal);

    }



}
