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
        private readonly InvoiceForm _invoiceForm;
        private readonly VetForm _vetForm;
        private readonly OwnerForm _ownerForm;

        VetForm VetForm = new VetForm();
        //OwnerForm ownerForm = new OwnerForm();
        TreatmentForm treatmentForm = new TreatmentForm();
        public Main()
        {
            InitializeComponent();


            var consultationService = new ConsultationService();
            _consultation = new Consultation(consultationService, consultationService); // I dont understand this but it works
                                                                                        //Needs a parameter becuase interfacse but we put same thing twice??
            var invoiceService = new InvoiceService();
            _invoiceForm = new InvoiceForm(invoiceService, invoiceService);

            var ownerService = new OwnerService();
            _ownerForm = new OwnerForm(ownerService, invoiceService);
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
            _ownerForm.Show();
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

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            _invoiceForm.Show();
            this.Hide();
        }

        private void CreatePet_Click(object sender, EventArgs e)
        {
            var petForm = new PetForm(); // Create a new instance
            petForm.Show();
            this.Hide(); // Hides the current form
        }
    }
}
