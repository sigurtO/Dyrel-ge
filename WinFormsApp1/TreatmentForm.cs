using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Service;

namespace WinFormsApp1
{
    public partial class TreatmentForm : Form
    {
        private readonly ITreatmentService _treatmentService;
        private readonly IOwnerRelated _ownerRelatedService;
        private readonly IVetinarianRelated _veterianRelated;
        private OwnerService ownerRelatedService1;
        private OwnerService ownerRelatedService2;

        public TreatmentForm(ITreatmentService treatmentService, IOwnerRelated ownerRelatedService, IVetinarianRelated vetinarianRelated)
        {
            _treatmentService = treatmentService;
            _ownerRelatedService = ownerRelatedService;
            _veterianRelated = vetinarianRelated;
            InitializeComponent();
            InitializeAsync();
        }


        private async void InitializeAsync()
        {
            await LoadTreatmentAsync();
            await LoadOwnersAsync();
        }
        private async Task LoadTreatmentAsync()
        {
            try
            {
                dataGridViewTreatment.DataSource = await _treatmentService.LoadTreatmentDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading treatment: {ex.Message}");
            }
        }

        private async Task LoadOwnersAsync()
        {
            try
            {
                comboBoxTreatmentOwner.DataSource = await _ownerRelatedService.LoadOwnerDataAsync();
                comboBoxTreatmentOwner.DisplayMember = "FirstName";
                comboBoxTreatmentOwner.ValueMember = "OwnerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading owners: {ex.Message}");
            }
        }

        private async void comboBoxTreatmentOwner_SelectedIndexChanged(object sender, EventArgs e) //Index changed in Owner box
        {
            if (comboBoxTreatmentOwner.SelectedValue == null || !(comboBoxTreatmentOwner.SelectedValue is int ownerId) || ownerId <= 0)
            {
                comboBoxTreatmentPet.DataSource = null;
                comboBoxTreatmentVet.DataSource = null;
                return;
            }

            try
            {
                comboBoxTreatmentPet.DataSource = await _ownerRelatedService.GetPetsByOwnerAsync(ownerId);
                comboBoxTreatmentPet.DisplayMember = "Name";
                comboBoxTreatmentPet.ValueMember = "PetID";
                comboBoxTreatmentVet.DataSource = null; // Clear vet when owner changes
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading pets: {ex.Message}");
            }
        }

        private async void comboBoxTreatmentPet_SelectedIndexChanged(object sender, EventArgs e) //Index changed in Pet box
        {
            if (comboBoxTreatmentPet.SelectedValue == null || !(comboBoxTreatmentPet.SelectedValue is int petId) || petId <= 0)
            {
                comboBoxTreatmentVet.DataSource = null;
                return;
            }

            try
            {
                comboBoxTreatmentVet.DataSource = await _veterianRelated.GetVeterinariansByPetAsync(petId);
                comboBoxTreatmentVet.DisplayMember = "FirstName";
                comboBoxTreatmentVet.ValueMember = "PetDocID";
                comboBoxTreatmentConsultation.DataSource = await _treatmentService.GetConsultationFromPetDataAsync(petId);
                comboBoxTreatmentConsultation.ValueMember = "ConsultationID"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading veterinarians: {ex.Message}");
            }
        }


        private async void buttonDeleteTreatment_Click(object sender, EventArgs e)
        {
            if (dataGridViewTreatment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a treatment to delete");
                return;
            }

            var treatmentId = (int)dataGridViewTreatment.SelectedRows[0].Cells["TreatmentID"].Value;

            try
            {
                await _treatmentService.DeleteTreatmentAsync(treatmentId);
                MessageBox.Show("Treatment deleted successfully");
                await LoadTreatmentAsync(); // Refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting treatment: {ex.Message}");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void buttonBackTreatment_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private async void buttonAddTreatment_Click_1(object sender, EventArgs e)
        {
            if (comboBoxTreatmentOwner.SelectedValue == null || comboBoxTreatmentPet.SelectedValue == null || comboBoxTreatmentVet.SelectedValue == null || comboBoxTreatmentConsultation.SelectedValue == null)
            {
                MessageBox.Show("Please select all fields before adding a treatment.");
                return;
            }
            try
            {   
                int ownerId = (int)comboBoxTreatmentOwner.SelectedValue;
                int petDocId = (int)comboBoxTreatmentPet.SelectedValue;
                int consultationId = (int)comboBoxTreatmentConsultation.SelectedValue;
                int price = string.IsNullOrWhiteSpace(textBoxPriceTreatment.Text) ? 0 : int.Parse(textBoxPriceTreatment.Text);
                DateTime date = textBoxDateTreatment.Value;
                string notes = textBoxNotesTreatment.Text;
                await _treatmentService.AddTreatmentAsync(ownerId, petDocId, consultationId, price, date, notes, (int)comboBoxTreatmentPet.SelectedValue);
                MessageBox.Show("Treatment added successfully");
                await LoadTreatmentAsync(); // Refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding treatment: {ex.Message}");
            }
        }

        private void comboBoxTreatmentConsultation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTreatmentConsultation.SelectedValue == null || !(comboBoxTreatmentConsultation.SelectedValue is int consultationId) || consultationId <= 0)
            {
                textBoxPriceTreatment.Text = string.Empty;
                return;
            }
            try
            {
                var consultationDetails = _treatmentService.GetConsultationFromPetDataAsync(consultationId).Result;
                if (consultationDetails.Rows.Count > 0)
                {
                    textBoxPriceTreatment.Text = consultationDetails.Rows[0]["Price"].ToString();
                }
                else
                {
                    textBoxPriceTreatment.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading consultation details: {ex.Message}");
            }
        }
    }
}
