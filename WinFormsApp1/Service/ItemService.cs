using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Service
{
    //Lukas
    public class ItemService : IitemService
    {
        public async Task<DataTable> LoadItemDataAsync()
        {
            try
            {
                return await Program.dbServices.DbReadItems.GetAllItems();
            }
            catch (Exception )
            {
                throw;
            }
        }

        public void ExportToTextFile(DataGridView dataGridView, string filePath)
        {
            decimal totalInventoryValue = 0;

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Item\tPrice\tAmount\tTotal Value"); // Header

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow) // skip hvis empty
                    {
                        string itemName = row.Cells["Name"].Value.ToString();
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        int amount = Convert.ToInt32(row.Cells["Amount"].Value);
                        decimal totalValue = price * amount;

                        totalInventoryValue += totalValue;

                        
                        writer.WriteLine($"{itemName}\t{price}\t{amount}\t{totalValue}");
                    }
                }

                writer.WriteLine("\nTotal Inventory Worth: " + totalInventoryValue);
            }

            MessageBox.Show("Export completed! Total Inventory Worth: " + totalInventoryValue, "Success");
        }
    }
}
