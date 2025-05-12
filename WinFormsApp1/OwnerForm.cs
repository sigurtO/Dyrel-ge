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

namespace WinFormsApp1
{
    public partial class OwnerForm : Form
    {
        private OwnerService ownerService = new OwnerService();

        public OwnerForm()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // loads UI
            try
            {
                await ownerService.LoadOwnerDataAsync(dataGridViewOwner); // Load the data into the DataGridView
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load owners:");
                dataGridViewOwner.DataSource = null; // Clear the DataGridView
            }
        }

        private async void AddOwnerButton_Click(object sender, EventArgs e)
        {
            await ownerService.HandleAddOwnerAsync(textBoxFirstName, textBoxLastName, textBoxEmail, textBoxPhoneNumber, textBoxAdress);
            await ownerService.LoadOwnerDataAsync(dataGridViewOwner); // Refresh the DataGridView


        }
        public async void OwnerForm_Load(object sender, EventArgs e)
        {
            try
            {
                await ownerService.LoadOwnerDataAsync(dataGridViewOwner); // Load the data into the DataGridView
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load owners:");
                dataGridViewOwner.DataSource = null; // Clear the DataGridView
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void dataGridViewOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}