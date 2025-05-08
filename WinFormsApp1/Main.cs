using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        Consultation Consultation = new Consultation();
        VetForm VetForm = new VetForm();
        OwnerForm ownerForm = new OwnerForm();
        TreatmentForm treatmentForm = new TreatmentForm();
        public Main()
        {
            InitializeComponent();
        }

        private void buttonConsultation_Click(object sender, EventArgs e)
        {
            Consultation.Show();
            this.Hide();
        }
        private void buttonVets_Click(object sender, EventArgs e)
        {
            VetForm.Show();
            this.Hide();
        }
        private void buttonOwners_Click(object sender, EventArgs e)
        {
            ownerForm.Show();
            this.Hide();
        }

        private void buttonBackMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void buttonTreatment_Click(object sender, EventArgs e)
        {
            treatmentForm.Show(); 
            this.Hide();
        }
    }
}
