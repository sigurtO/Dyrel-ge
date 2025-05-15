using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;
using WinFormsApp1.Service;

namespace WinFormsApp1
{
    public partial class PetForm : Form
    {
        private readonly IOwnerRelated _ownerRelatedService;
        private readonly IPetService _petService;

        public PetForm(IOwnerRelated ownerRelatedService, IPetService petService)
        {
            _ownerRelatedService = ownerRelatedService;
            _petService = petService;
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await LoadPetsAsync();
        }

        private async Task LoadPetsAsync()
        {
            try
            {
                dataGridView1.DataSource = await _petService.LoadPetDataAsync();
                dataGridView1.Columns["PetID"].Visible = false; // Hide ID column
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading pets: {ex.Message}");
                dataGridView1.DataSource = null;
            }
        }

        private async void PetCreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PetNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PetBreedTextBox.Text) ||
                string.IsNullOrWhiteSpace(PetOwnerTextBoxID.Text) ||
                string.IsNullOrWhiteSpace(PetSpeciesTextBox.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            try
            {
                var newPet = new PetClass(
                    Convert.ToInt32(PetOwnerTextBoxID.Text),
                    Convert.ToInt32(PetDocIDTextBox.Text),
                    PetNameTextBox.Text,
                    petDateTimePicker.Value,
                    PetSpeciesTextBox.Text,
                    PetBreedTextBox.Text);

                await _petService.AddPetAsync(newPet);
                MessageBox.Show("Pet added successfully");
                await LoadPetsAsync();

                // Clear fields
                PetNameTextBox.Clear();
                PetBreedTextBox.Clear();
                PetOwnerTextBoxID.Clear();
                PetSpeciesTextBox.Clear();
                PetDocIDTextBox.Clear();
                petDateTimePicker.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding pet: {ex.Message}");
            }
        }

    }
}
