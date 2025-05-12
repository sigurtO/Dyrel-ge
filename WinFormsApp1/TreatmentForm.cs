using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Service;

namespace WinFormsApp1
{
    public partial class TreatmentForm : Form
    {
        private TreatmentService treatmentService = new TreatmentService();
        public TreatmentForm()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // loads UI
            try
            {
                await treatmentService.LoadTreatmentDataAsync(dataGridViewTreatment); // Load the data into the DataGridView
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load Treatments:");
                dataGridViewTreatment.DataSource = null; // Clear the DataGridView
            }
        }
        private async Task LoadOwnersAsync()
        {
            try
            {
                comboBoxTreatmentOwner.DataSource = await _treatmentService.LoadOwnersAsync();
                comboBoxTreatmentOwner.DisplayMember = "FirstName";
                comboBoxTreatmentOwner.ValueMember = "OwnerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading owners: {ex.Message}");
            }
        }

        private void buttonBackTreatment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
