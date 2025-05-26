using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Objects;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{
    //Daniel
    public partial class VetForm : Form
    {
        private readonly IVeterinarianService vetService;

        public VetForm(IVeterinarianService vetService)
        {
            InitializeComponent();
            this.vetService = vetService;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadVetsAsync();
        }

        private async Task LoadVetsAsync()
        {
            try
            {
                dataGridViewVets.DataSource = await vetService.LoadVetsAsync();
            }
            catch (VetServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newVet = new VetClass(
                    0,
                    textBoxFirstName.Text,
                    textBoxLastName.Text,
                    textBoxUsername.Text,
                    PasswordHelper.HashPassword(textBoxPassword.Text),
                    textBoxSpeciale.Text
                );

                await vetService.AddVetAsync(newVet);
                MessageBox.Show("Veterinarian added successfully!");

                await LoadVetsAsync();
                ClearForm();
            }
            catch (VetServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxSpeciale.Clear();
        }

        private void buttonBackVet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}