using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Service
{
    public class InvoiceService : IInvoiceService
    {
        public async Task<DataTable> LoadInvoiceAsync()
        {
			try
			{
                DataTable Invoice = await Program.dbServices.DbReadInvoice.GetAllInvoicesAsync();
                return Invoice;
            }
			catch (Exception)
			{

				throw;
			}
        }

        public async Task<DataTable> LoadOwnersAsync() //load owner into combobox
        {

            try
            {
                DataTable owners = await Program.dbServices.DbReadInvoice.GetOwnerIdFrom();

                DataRow newRow = owners.NewRow();
                newRow["OwnerID"] = 0;
                newRow["FirstName"] = "-- Select Owner --";
                owners.Rows.InsertAt(newRow, 0);

                return owners;
            }
            catch (Exception)
            {

                throw; // do somethign at some point
            }

        }

        public async Task<DataTable> GetPetByOwnerAsync(int ownerId)
        {
            if (ownerId <= 0) return null;
            try
            {
                return await Program.dbServices.DbReadInvoice.GetPetsByOwnerAsync(ownerId);
            }
            catch (Exception)
            {
                throw;
            }

        }



    }
}
