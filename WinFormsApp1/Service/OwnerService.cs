using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class OwnerService : IOwnerService  // Explicitly implement the interface
    {
        public async Task<DataTable> LoadOwnerDataAsync()
        {
            try
            {
                return await Program.dbServices.DbReadOwner.ShowAllOwnersAsync();
            }
            catch (Exception ex)
            {
                // Throw instead of showing MessageBox here
                throw new OwnerServiceException("Failed to load owners", ex);
            }
        }

        public async Task AddOwnerAsync(OwnerClass owner)  // Changed to match interface
        {
            try
            {
                await Program.dbServices.DbCreateOwner.AddOwnerAsync(owner);
            }
            catch (Exception ex)
            {
                throw new OwnerServiceException("Failed to add owner", ex);
            }
        }

        public async Task UpdateOwnerAsync(OwnerClass owner, int ownerId)
        {
            try
            {
                await Program.dbServices.DbUpdateOwner.UpdateOwnerAsync(owner, ownerId);
            }
            catch (Exception ex)
            {
                throw new OwnerServiceException($"Failed to update owner {ownerId}", ex);
            }
        }

        // Missing from original code - add this to fulfill interface
      
    }

    // Add custom exception class
    public class OwnerServiceException : Exception
    {
        public OwnerServiceException(string message, Exception inner)
            : base(message, inner) { }
    }
}