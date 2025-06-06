﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Service;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        private readonly Consultation _consultation;
        private readonly InvoiceForm _invoiceForm;

        private readonly TreatmentForm _treatmentForm;

        private readonly VetForm _vetForm;
        private readonly OwnerForm _ownerForm;

        private readonly PetForm _petForm;
        private readonly Items _itemForm;


        public Main()
        {
            InitializeComponent();



            var consultationService = new ConsultationService();
            _consultation = new Consultation(consultationService, consultationService, consultationService); // I dont understand this but it works
                                                                                                             //Needs a parameter becuase interfacse but we put same thing twice?? sometimes thre times?
            var invoiceService = new InvoiceService();
            _invoiceForm = new InvoiceForm(invoiceService, invoiceService);


            var ownerService = new OwnerService();
            _ownerForm = new OwnerForm(ownerService, invoiceService);

            var ownerRelatedService = new OwnerService();


            var petService = new PetService();
            _petForm = new PetForm(petService, petService);

            var petLoadRelated = new PetService();



            var veterinarianService = new VetService();
            _vetForm = new VetForm(veterinarianService);

            var veterinarianRelated = new VetService();

            var treatmentService = new TreatmentService();
            _treatmentForm = new TreatmentForm(treatmentService, invoiceService, consultationService);

            var itemService = new ItemService();
            _itemForm = new Items(itemService);


        }

        private void buttonConsultation_Click(object sender, EventArgs e)
        {
            _consultation.Show();
            this.Hide();
        }
        private void buttonVets_Click(object sender, EventArgs e)
        {
            _vetForm.Show();
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
            _treatmentForm.Show();
            this.Hide();
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            _invoiceForm.Show();
            this.Hide();
        }

        private void CreatePet_Click(object sender, EventArgs e)
        {

            _petForm.Show();
            this.Hide(); // Hides the current form
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            _itemForm.Show();
            this.Hide();
        }
    }
}
