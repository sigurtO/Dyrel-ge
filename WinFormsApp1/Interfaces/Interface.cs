using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Interfaces
{
    public interface IConsultationService
    {
        Task<DataTable> LoadConsultationDataAsync();
        Task<DataTable> GetVeterinariansByPetAsync(int petId);
        Task AddConsultationAsync(int ownerId, int petId, int vetId, DateTime date, int price, string notes);
        Task DeleteConsultationAsync(int consultationId);

        Task UpdateConsultationAsync(ConsultationClass consultation, int consultationId);
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


    public interface IOwnerService
    {
        Task AddOwnerAsync(OwnerClass owner);
        Task UpdateOwnerAsync(OwnerClass owner, int ownerId);
        Task<DataTable> LoadOwnerDataAsync();
    }



    public interface IPetService 
    {   
            Task<DataTable> LoadPetDataAsync();
            Task AddPetAsync(PetClass pet);
          
 
    }

}
