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
        private readonly IPetLoadComboBoxRelated _IPetLoadComboBoxRelated;
        private readonly IPetService _petService;

        public PetForm(IPetLoadComboBoxRelated petLoadService, IPetService petService)
        {
            _IPetLoadComboBoxRelated = petLoadService;
            _petService = petService;
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await LoadPetsAsync();
            await LoadOwnersAsync();
            await LoadVetsAsync();
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
            if (comboBoxPetOwnerID.SelectedValue == null ||
         comboBoxPetDocID.SelectedValue == null ||
         string.IsNullOrWhiteSpace(PetNameTextBox.Text) ||
         string.IsNullOrWhiteSpace(PetBreedTextBox.Text) ||
         string.IsNullOrWhiteSpace(PetSpeciesTextBox.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            try
            {
                var newPet = new PetClass(
                    (int)comboBoxPetOwnerID.SelectedValue,
                    (int)comboBoxPetDocID.SelectedValue,
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
                PetSpeciesTextBox.Clear();
                petDateTimePicker.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding pet: {ex.Message}");
            }
        }


        private async Task LoadOwnersAsync()
        {
            try
            {
                comboBoxPetOwnerID.DataSource = await _IPetLoadComboBoxRelated.LoadOwnerDataAsync();
                comboBoxPetOwnerID.DisplayMember = "FirstName";
                comboBoxPetOwnerID.ValueMember = "OwnerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading owners: {ex.Message}");
            }
        }

        private async Task LoadVetsAsync()
        {
            try
            {
                comboBoxPetDocID.DataSource = await _IPetLoadComboBoxRelated.LoadVetsDataAsync();
                comboBoxPetDocID.DisplayMember = "FirstName";
                comboBoxPetDocID.ValueMember = "PetDocID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Vets: UI ERROR {ex.Message}");
            }
        }

    }
}
