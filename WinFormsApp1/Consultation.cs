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
using WinFormsApp1.Objects;
using WinFormsApp1.Service;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{

    public partial class Consultation : Form
    {
        private readonly IConsultationService _consultationService;


        public Consultation(IConsultationService consultationService)
        {
            _consultationService = consultationService;
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await LoadConsultationsAsync();
            await LoadOwnersAsync();
        }

        private async Task LoadConsultationsAsync()
        {
            try
            {
                dataGridView.DataSource = await _consultationService.LoadConsultationDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading consultations: {ex.Message}");
            }
        }

        private async Task LoadOwnersAsync()
        {
            try
            {
                comboBoxOwner.DataSource = await _consultationService.LoadOwnersAsync();
                comboBoxOwner.DisplayMember = "FirstName";
                comboBoxOwner.ValueMember = "OwnerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading owners: {ex.Message}");
            }
        }



        private async void comboBoxOwner_SelectedIndexChanged(object sender, EventArgs e) //Index changed in Owner box
        {
            if (comboBoxOwner.SelectedValue == null || !(comboBoxOwner.SelectedValue is int ownerId) || ownerId <= 0)
            {
                comboBoxPet.DataSource = null;
                comboBoxVet.DataSource = null;
                return;
            }

            try
            {
                comboBoxPet.DataSource = await _consultationService.GetPetsByOwnerAsync(ownerId);
                comboBoxPet.DisplayMember = "Name";
                comboBoxPet.ValueMember = "PetID";
                comboBoxVet.DataSource = null; // Clear vet when owner changes
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading pets: {ex.Message}");
            }
        }

        private async void comboBoxPet_SelectedIndexChanged(object sender, EventArgs e) //Index changed in Pet box
        {
            if (comboBoxPet.SelectedValue == null || !(comboBoxPet.SelectedValue is int petId) || petId <= 0)
            {
                comboBoxVet.DataSource = null;
                return;
            }

            try
            {
                comboBoxVet.DataSource = await _consultationService.GetVeterinariansByPetAsync(petId);
                comboBoxVet.DisplayMember = "FirstName";
                comboBoxVet.ValueMember = "PetDocID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading veterinarians: {ex.Message}");
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxOwner.SelectedValue == null || comboBoxPet.SelectedValue == null ||
                comboBoxVet.SelectedValue == null)
            {
                MessageBox.Show("Please select owner, pet and veterinarian");
                return;
            }

            try
            {
                await _consultationService.AddConsultationAsync(
                    (int)comboBoxOwner.SelectedValue,
                    (int)comboBoxPet.SelectedValue,
                    (int)comboBoxVet.SelectedValue,
                    textBoxDate.Value,
                    Convert.ToInt32(textBoxPrice.Value),
                    textBoxDate.Text);

                MessageBox.Show("Consultation added successfully");
                await LoadConsultationsAsync(); // Refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding consultation: {ex.Message}");
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a consultation to delete");
                return;
            }

            var consultationId = (int)dataGridView.SelectedRows[0].Cells["ConsultationID"].Value;

            try
            {
                await _consultationService.DeleteConsultationAsync(consultationId);
                MessageBox.Show("Consultation deleted successfully");
                await LoadConsultationsAsync(); // Refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting consultation: {ex.Message}");
            }
        }

        private void buttonBackConsultation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
