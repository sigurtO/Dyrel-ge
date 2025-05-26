using System;
using System.Data;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class PetService : IPetService, IPetLoadComboBoxRelated
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



        public async Task<DataTable> LoadOwnerDataAsync()     // load owners into ComboBOx
        {
            try
            {
                DataTable owners = await Program.dbServices.DbReadPet.GetOwnersAsync();

                DataRow newRow = owners.NewRow();
                newRow["OwnerID"] = 0;
                newRow["FirstName"] = "-- Select Owner --";
                owners.Rows.InsertAt(newRow, 0);

                return owners;
            }
            catch (Exception ex)
            {
                throw new VetServiceException("Failed to load owners", ex);
            }
        }


        public async Task<DataTable> LoadVetsDataAsync()
        {
            try
            {
                DataTable vets = await Program.dbServices.DbReadPet.GetAllVetsAsync();

                return vets;

            }
            catch (Exception ex)
            {
                throw new VetServiceException("Failed to load veterinarians SERVICE CLASS ERROR", ex);
            }
        }


    }

    public class PetServiceException : Exception
    {
        public PetServiceException(string message, Exception inner)
            : base(message, inner) { }
    }
}