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
    }
}
