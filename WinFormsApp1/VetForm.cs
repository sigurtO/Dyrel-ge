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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class VetForm : Form
    {
        private readonly VetService vetService = new VetService();

        public VetForm()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await vetService.LoadVetsAsync(dataGridViewVets);
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            await vetService.HandleAddVetAsync(
                textBoxFirstName,
                textBoxLastName,
                textBoxUsername,
                textBoxPassword,
                textBoxSpeciale
            );
            await vetService.LoadVetsAsync(dataGridViewVets);
            ClearForm();
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
