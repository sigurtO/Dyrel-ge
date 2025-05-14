using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Service;
using WinFormsApp1;

namespace WinFormsApp1
{

    public partial class PetForm : Form
    {
        private PetService petService = new PetService();

        public PetForm()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // loads UI
            try
            {
                await petService.LoadPetDataAsync(dataGridView1); // Load the data into the DataGridView
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load pets:");
                dataGridView1.DataSource = null; // Clear the DataGridView
            }
        }

        private async void AddPetButton_Click(object sender, EventArgs e)
        {
            await PetService.HandleAddPetAsync(PetNameTextBox, PetNameTextBox, PetBreedTextBox, PetSpeciesTextBox, PetOwnerTextBoxID);
            await PetService.LoadPetDataAsync(dataGridView1); // Refresh the DataGridView


        }
        public async void PetForm_Load(object sender, EventArgs e)
        {
            try
            {
                await petService.LoadPetDataAsync(dataGridView1); // Load the data into the DataGridView
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load owners:");
                dataGridView1.DataSource = null; // Clear the DataGridView
            }

        }

        private void CreatePetButton(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}