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
    public class TreatmentService : ITreatmentService
    {
        public async Task LoadTreatmentDataAsync(DataGridView gridView)       //Load the data into the DataGridView
        {
            try
            {
                DataTable Treatments = await Program.dbServices.DbReadTreatment.ShowAllTreatmentsAsync();
                gridView.DataSource = Treatments;
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load Treatments:");
                gridView.DataSource = null; // Clear the DataGridView
            }
        }
        public async Task<DataTable> LoadOwnersAsync()     // load owners into ComboBOx
        {
            try
            {
                DataTable owners = await Program.dbServices.DbReadConsultation.GetOwnersAsync();

                DataRow newRow = owners.NewRow();
                newRow["OwnerID"] = 0;
                newRow["FirstName"] = "-- Select Owner --";
                owners.Rows.InsertAt(newRow, 0);

                return owners;
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException("Failed to load owners", ex);
            }
        }
    }
}
