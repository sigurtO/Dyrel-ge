using System;
using System.Data;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class PetService : IPetService
    {
        public async Task<DataTable> LoadPetDataAsync()
        {
            try
            {
                return await Program.dbServices.DbReadPet.ShowAllPetAsync();
            }
            catch (Exception ex)
            {
                throw new PetServiceException("Failed to load pets", ex);
            }
        }

        public async Task AddPetAsync(PetClass pet)
        {
            try
            {
                await Program.dbServices.DbCreatePet.AddPetAsync(pet);
            }
            catch (Exception ex)
            {
                throw new PetServiceException("Failed to add pet", ex);
            }
        }

       

    }

    public class PetServiceException : Exception
    {
        public PetServiceException(string message, Exception inner)
            : base(message, inner) { }
    }
}