using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class OwnerService
    {
        public async Task LoadOwnerDataAsync(DataGridView gridView)       //Load the data into the DataGridView
        {
            try
            {
                DataTable owners = await Program.DbRead.ShowAllOwnersAsync();
                gridView.DataSource = owners;
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load owners:");
                gridView.DataSource = null; // Clear the DataGridView
            }
        }
    
        public async Task HandleAddOwnerAsync(TextBox textBoxFirstName, TextBox textBoxLastName, TextBox textBoxEmail, TextBox textBoxPhoneNumber, TextBox textBoxAdress)
        {
            try
            {
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxLastName.Text;
                string email = textBoxEmail.Text;
                int phoneNumber = Convert.ToInt32(textBoxPhoneNumber.Text);
                string adress = textBoxAdress.Text;
                OwnerClass newOwner = new OwnerClass(firstName, lastName, email, phoneNumber, adress);
                await Program.DbCreate.AddOwnerAsync(newOwner);
            }
            catch
            {
                MessageBox.Show("Error:: Failed to add owner: ");
            }
        }
    }
}
