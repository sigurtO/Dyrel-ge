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
            await vetService.HandleAddVetAsync(textBoxName);
            await vetService.LoadVetsAsync(dataGridViewVets);
            textBoxName.Clear();
        }
    }
}
