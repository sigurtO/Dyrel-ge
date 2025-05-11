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
using WinFormsApp1.Interfaces;

namespace WinFormsApp1
{
    public partial class InvoiceForm : Form
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IOwnerRelated _ownerRelatedService;
        int _currentTotal = 0;
        public InvoiceForm(IInvoiceService invoiceService, IOwnerRelated ownerRelated)
        {
            _invoiceService = invoiceService;
            _ownerRelatedService = ownerRelated;
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await LoadInvoiceDataAsync();
            await LoadOwnerDataAsync();
        }

        private async Task LoadInvoiceDataAsync()
        {
            try
            {
                dataGridViewInvoice.DataSource = await _invoiceService.LoadInvoiceAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading consultations: {ex.Message}");
            }
        }

        private async Task LoadOwnerDataAsync()
        {
            try
            {
                comboBoxOwnerId.DataSource = await _ownerRelatedService.LoadOwnerDataAsync();
                comboBoxOwnerId.DisplayMember = "FirstName";
                comboBoxOwnerId.ValueMember = "OwnerId";

                comboBoxItemId.DataSource = await _invoiceService.GetAllItemsDataAsync();
                comboBoxItemId.DisplayMember = "Name";
                comboBoxItemId.ValueMember = "ItemID";
            }
            catch (Exception)
            {

                throw; // add later
            }
        }

        private async void comboBoxOwnerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOwnerId.SelectedValue == null || !(comboBoxOwnerId.SelectedValue is int ownerId) || ownerId <= 0)
            {
                comboBoxPetId.DataSource = null;
                comboBoxConsultationId.DataSource = null;
                comboBoxConsultationId.DataSource = null;
                comboBoxTreatmentId.DataSource = null;
                comboBoxCageId.DataSource = null;
                return;
            }
            try
            {
                comboBoxPetId.DataSource = await _ownerRelatedService.GetPetsByOwnerAsync(ownerId);
                comboBoxPetId.DisplayMember = "Name";
                comboBoxPetId.ValueMember = "PetID";


                DataTable consultations = await _invoiceService.GetConsultationFromPetDataAsync(ownerId);

                comboBoxConsultationId.DataSource = consultations;
                comboBoxConsultationId.ValueMember = "ConsultationID";
                comboBoxConsultationId.DisplayMember = "Notes"; // could we display date??
                int price = Convert.ToInt32(consultations.Rows[0]["Price"]);
                int.TryParse(textBoxTotalAmount.Text, out _currentTotal);
                int newTotal = _currentTotal + price;
                textBoxTotalAmount.Text = newTotal.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void comboBoxConsultationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxConsultationId.SelectedValue == null || !(comboBoxConsultationId.SelectedValue is int consultationId) || consultationId <= 0) //blank if we
            {
                comboBoxTreatmentId.DataSource = null;
                comboBoxCageId.DataSource = null;
                return;
            }
            try
            {

                DataTable treatment = await _invoiceService.GetTreatmentFromConsultationDataAsync(consultationId);
                //GetTreatmentFromConsultationDataAsync
                comboBoxTreatmentId.DataSource = treatment;
                comboBoxTreatmentId.DisplayMember = "Notes";
                comboBoxTreatmentId.ValueMember = "TreatmentID";
                int price = Convert.ToInt32(treatment.Rows[0]["Price"]);
                int.TryParse(textBoxTotalAmount.Text, out _currentTotal); //WinForms is so #$%&*#@!@# outdated and fixing this is waste of time
                int newTotal = _currentTotal + price;
                textBoxTotalAmount.Text = newTotal.ToString();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private async void comboBoxTreatmentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTreatmentId.SelectedValue == null || !(comboBoxTreatmentId.SelectedValue is int treatmentId) || treatmentId <= 0)
            {
                comboBoxCageId.DataSource = null;
                return;
            }

            try
            {
                DataTable cage = await _invoiceService.CheckCageFromTreatmentDataAsync(treatmentId);
                comboBoxCageId.DataSource = cage;
                comboBoxCageId.DisplayMember = "DisplayText"; // Cleaner column name
                comboBoxCageId.ValueMember = "CageID";
                if (cage.Rows.Count > 0)
                {
                    object rawPrice = cage.Rows[0]["cagePrice"];
                    int price = (rawPrice == DBNull.Value) ? 0 : Convert.ToInt32(rawPrice);
                    int.TryParse(textBoxTotalAmount.Text, out _currentTotal);
                    int newTotal = _currentTotal + price;
                    textBoxTotalAmount.Text = newTotal.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cage information: {ex.Message}");
            }
        }

    }
}
