using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;


namespace WinFormsApp1.Service
{
    //Emil
    public class VetService : IVeterinarianService
    {
        public async Task<DataTable> LoadVetsAsync()
        {
            try
            {
                return await Program.dbServices.DbReadVet.GetAllVetsAsync();
            }
            catch (Exception ex)
            {
                throw new VetServiceException("Failed to load veterinarians", ex);
            }
        }

        public async Task AddVetAsync(VetClass vet)
        {
            if (vet == null)
            {
                throw new ArgumentNullException(nameof(vet));
            }

            if (string.IsNullOrWhiteSpace(vet.FirstName) ||
                string.IsNullOrWhiteSpace(vet.Username) ||
                string.IsNullOrWhiteSpace(vet.PasswordHash))
            {
                throw new VetServiceException("First name, username and password are required");
            }

            try
            {
                await Program.dbServices.DbCreateVet.CreateVetAsync(vet);
            }
            catch (Exception ex)
            {
                throw new VetServiceException("Failed to add veterinarian", ex);
            }
        }

        public async Task<VetClass> AuthenticateAsync(string username, string password)
        {
            try
            {
                return await Program.dbServices.DbReadVet.AuthenticateVetAsync(username, password);
            }
            catch (Exception ex)
            {
                throw new VetServiceException("Failed to authenticate veterinarian", ex);
            }
        }
    }

    public class VetServiceException : Exception
    {
        public VetServiceException(string message) : base(message) { }
        public VetServiceException(string message, Exception inner) : base(message, inner) { }
    }
}