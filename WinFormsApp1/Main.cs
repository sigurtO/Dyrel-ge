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
    public partial class Main : Form
    {
        private readonly Consultation _consultation;
        VetForm VetForm = new VetForm();
        public Main()
        {
            InitializeComponent();
            var consultationService = new ConsultationService();
            _consultation = new Consultation(consultationService);

        }

        private void buttonConsultation_Click(object sender, EventArgs e)
        {
            _consultation.Show();
            this.Hide();
        }
        private void buttonVets_Click(object sender, EventArgs e)
        {
            VetForm.Show();
            this.Hide();
        }
        private void buttonOwners_Click(object sender, EventArgs e)
        {
            OwnerForm ownerForm = new OwnerForm();
            ownerForm.Show();
            this.Hide();
        }
    }
}
