using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class VetService
    {
        public async Task LoadVetsAsync(DataGridView gridView)
        {
            try
            {
                DataTable vets = await Program.DbRead.GetAllVetsAsync();
                gridView.DataSource = vets;
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Failed to load veterinarians");
                gridView.DataSource = null;
            }
        }
        public async Task HandleAddVetAsync(TextBox textBoxName)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            VetClass newVet = new VetClass(0, textBoxName.Text);
            await Program.DbCreate.CreateVetAsync(newVet);
            MessageBox.Show("Veterinarian added successfully!");
        }
    }
}
