using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Service
{
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
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow) // Last row is empty in datagird view so we skip this
                    {
                        string rowData = "";

                        // Loop through columns
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            rowData += cell.Value?.ToString() + "\t"; // tab between each cell
                        }

                        writer.WriteLine(rowData.Trim()); // Write row data
                    }
                }
            }

            MessageBox.Show("Export completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
