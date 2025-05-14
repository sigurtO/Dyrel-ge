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

        public TreatmentForm(ITreatmentService treatmentService, IOwnerRelated ownerRelatedService)
        {
            _treatmentService = treatmentService;
            _ownerRelatedService = ownerRelatedService;
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

        private async void comboBoxOwner_SelectedIndexChanged(object sender, EventArgs e) //Index changed in Owner box
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

        private async void comboBoxPet_SelectedIndexChanged(object sender, EventArgs e) //Index changed in Pet box
        {
            if (comboBoxTreatmentPet.SelectedValue == null || !(comboBoxTreatmentPet.SelectedValue is int petId) || petId <= 0)
            {
                comboBoxTreatmentVet.DataSource = null;
                return;
            }

            try
            {
                comboBoxTreatmentVet.DataSource = await _treatmentService.GetVeterinariansByPetAsync(petId);
                comboBoxTreatmentVet.DisplayMember = "FirstName";
                comboBoxTreatmentVet.ValueMember = "PetDocID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading veterinarians: {ex.Message}");
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxTreatmentOwner.SelectedValue == null || comboBoxTreatmentPet.SelectedValue == null ||
                comboBoxTreatmentVet.SelectedValue == null)
            {
                MessageBox.Show("Please select owner, pet and veterinarian");
                return;
            }

            try
            { //int ownerId, int petDocId, int consultationId, int price, DateTime date, string notes, int petID
                await _treatmentService.AddTreatmentAsync(
                    (int)comboBoxTreatmentOwner.SelectedValue,
                    (int)comboBoxTreatmentVet.SelectedValue,
                    (int)comboBoxTreatmentConsultation.SelectedValue,
                    Convert.ToInt32(textBoxPriceTreatment.Text),
                    textBoxDateTreatment.Value,
                    textBoxNotesTreatment.Text,
                    (int)comboBoxTreatmentPet.SelectedValue);

                MessageBox.Show("Consultation added successfully");
                await LoadTreatmentAsync(); // Refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding consultation: {ex.Message}");
            }
        }

        private void buttonBackTreatment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
