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

namespace WinFormsApp1
{
    public partial class OwnerForm : Form
    {
        private readonly IOwnerService _ownerService;
        private readonly IOwnerRelated _ownerRelatedService;

        public OwnerForm(IOwnerService ownerService, IOwnerRelated ownerRelatedService)
        {
            _ownerService = ownerService;
            _ownerRelatedService = ownerRelatedService;
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await LoadOwnersAsync();
        }

        private async Task LoadOwnersAsync()
        {
            try
            {
                dataGridViewOwner.DataSource = await _ownerService.LoadOwnerDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading owners: {ex.Message}");
                dataGridViewOwner.DataSource = null;
            }
        }

        private async void AddOwnerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("First name and last name are required");
                return;
            }

            try
            {
                var newOwner = new OwnerClass(
                 textBoxFirstName.Text,
                   textBoxLastName.Text,
                     textBoxEmail.Text, // email is third!
                       Convert.ToInt32(textBoxPhone.Text), // phone is int
                          textBoxAdress.Text);




                await _ownerService.AddOwnerAsync(newOwner);
                MessageBox.Show("Owner added successfully");
                await LoadOwnersAsync(); // Refresh grid

                // Clear input fields
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxPhone.Clear();
                textBoxEmail.Clear();
                textBoxAdress.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding owner: {ex.Message}");
            }
        }


        private async void dataGridView_CellEndEditOwner(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOwner.CurrentRow == null) return;

            try
            {
                var ownerId = Convert.ToInt32(dataGridViewOwner.CurrentRow.Cells["OwnerID"].Value); // <--- THIS LINE IS NEEDED!
                var owner = new OwnerClass(
                    dataGridViewOwner.CurrentRow.Cells["FirstName"].Value?.ToString(),
                    dataGridViewOwner.CurrentRow.Cells["LastName"].Value?.ToString(),
                    dataGridViewOwner.CurrentRow.Cells["Email"].Value?.ToString(),
                    Convert.ToInt32(dataGridViewOwner.CurrentRow.Cells["Phone"].Value),
                    dataGridViewOwner.CurrentRow.Cells["Adress"].Value?.ToString());

                await _ownerService.UpdateOwnerAsync(owner, ownerId);
                MessageBox.Show("Owner updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating owner: {ex.Message}");
                await LoadOwnersAsync(); // Refresh to revert any changes
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}