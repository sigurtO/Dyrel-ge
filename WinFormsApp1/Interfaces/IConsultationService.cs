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
        Task<DataTable> LoadOwnersAsync();
        Task<DataTable> GetPetsByOwnerAsync(int ownerId);
        Task<DataTable> GetVeterinariansByPetAsync(int petId);
        Task AddConsultationAsync(int ownerId, int petId, int vetId, DateTime date, int price, string notes);
        Task DeleteConsultationAsync(int consultationId);
    }
}
