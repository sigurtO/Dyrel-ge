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
using WinFormsApp1.Objects;

namespace WinFormsApp1
{
    public partial class InvoiceForm : Form
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IOwnerRelated _ownerRelatedService;
        private int _currentTotal = 0;
        public InvoiceForm(IInvoiceService invoiceService, IOwnerRelated ownerRelated)
        {
            _invoiceService = invoiceService;
            _ownerRelatedService = ownerRelated;
            InitializeComponent();
            InitializeAsync();
        }

        public async void InitializeAsync()
        {
            await LoadInvoiceDataAsync();
            await LoadOwnerDataAsync();
        }

        public async Task LoadInvoiceDataAsync()
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

        public async Task LoadOwnerDataAsync()
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
        //starting from here
        public async void comboBoxOwnerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOwnerId.SelectedValue == null || !(comboBoxOwnerId.SelectedValue is int ownerId) || ownerId <= 0)
            {
                comboBoxPetId.DataSource = null;
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


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private async void comboBoxPetId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPetId.SelectedValue == null || !(comboBoxPetId.SelectedValue is int petId) || petId <= 0)
            {
                comboBoxConsultationId.DataSource = null;
                comboBoxTreatmentId.DataSource = null;
                comboBoxCageId.DataSource = null;
                return;
            }
            try
            {
                DataTable consultations = await _invoiceService.GetConsultationFromPetDataAsync(petId);
                comboBoxConsultationId.DataSource = consultations;
                comboBoxConsultationId.ValueMember = "ConsultationID";
                comboBoxConsultationId.DisplayMember = "Notes";

                _currentTotal = await _invoiceService.CalculateTotalAmount(
                    consultations.Rows.Count > 0 ? Convert.ToInt32(consultations.Rows[0]["ConsultationID"]) : 0,
                    0, 0, 0, _currentTotal);

                textBoxTotalAmount.Text = _currentTotal.ToString();

            }
            catch (Exception)
            {

                throw;
            }


        }

        public async void comboBoxConsultationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxConsultationId.SelectedValue == null || !(comboBoxConsultationId.SelectedValue is int consultationId) || consultationId <= 0)
            {
                comboBoxTreatmentId.DataSource = null;
                comboBoxCageId.DataSource = null;
                return;
            }

            try
            {
                DataTable treatment = await _invoiceService.GetTreatmentFromConsultationDataAsync(consultationId);
                comboBoxTreatmentId.DataSource = treatment;
                comboBoxTreatmentId.DisplayMember = "Notes";
                comboBoxTreatmentId.ValueMember = "TreatmentID";

                _currentTotal = await _invoiceService.CalculateTotalAmount(
                    consultationId,
                    treatment.Rows.Count > 0 ? Convert.ToInt32(treatment.Rows[0]["TreatmentID"]) : 0,
                    0, 0, _currentTotal);

                textBoxTotalAmount.Text = _currentTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading treatment data: {ex.Message}");
            }
        }

        public async void comboBoxTreatmentId_SelectedIndexChanged(object sender, EventArgs e)
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
                comboBoxCageId.DisplayMember = "DisplayText";
                comboBoxCageId.ValueMember = "CageID";

                _currentTotal = await _invoiceService.CalculateTotalAmount(
                    Convert.ToInt32(comboBoxConsultationId.SelectedValue),
                    treatmentId,
                    cage.Rows.Count > 0 ? Convert.ToInt32(cage.Rows[0]["CageID"]) : 0,
                    0, _currentTotal);

                textBoxTotalAmount.Text = _currentTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cage information: {ex.Message}");
            }
        }
        public async void comboBoxItemId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItemId.SelectedValue == null || !(comboBoxItemId.SelectedValue is int itemId) || itemId <= 0)
            {
                return;
            }

            try
            {
                _currentTotal = await _invoiceService.CalculateTotalAmount(
                    comboBoxConsultationId.SelectedValue != null ? Convert.ToInt32(comboBoxConsultationId.SelectedValue) : 0,
                    comboBoxTreatmentId.SelectedValue != null ? Convert.ToInt32(comboBoxTreatmentId.SelectedValue) : 0,
                    comboBoxCageId.SelectedValue != null ? Convert.ToInt32(comboBoxCageId.SelectedValue) : 0,
                    itemId, _currentTotal);

                textBoxTotalAmount.Text = _currentTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total: {ex.Message}");
            }
        }


        public void CalculateNetAmount()
        {
            if (decimal.TryParse(textBoxTotalAmount.Text, out decimal totalAmount))
            {
                decimal discountPercentage = numericUpDownDiscount.Value;
                decimal netAmount = totalAmount * (1 - discountPercentage / 100);
                textBoxNetAmount.Text = netAmount.ToString("F2");
            }
        }
        public async void ButtonAddInvoice_Click(object sender, EventArgs e)
        {
            if (comboBoxOwnerId.SelectedValue == null ||
                comboBoxPetId.SelectedValue == null ||
                string.IsNullOrWhiteSpace(textBoxTotalAmount.Text) ||
                string.IsNullOrWhiteSpace(textBoxNetAmount.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            try
            {
                var invoice = new InvoiceClass(
                        comboBoxTreatmentId.SelectedValue != null ? (int?)Convert.ToInt32(comboBoxTreatmentId.SelectedValue) : null,
                        Convert.ToInt32(comboBoxOwnerId.SelectedValue),
                        comboBoxConsultationId.SelectedValue != null ? (int?)Convert.ToInt32(comboBoxConsultationId.SelectedValue) : null,
                        Convert.ToInt32(comboBoxPetId.SelectedValue),
                        comboBoxItemId.SelectedValue != null ? (int?)Convert.ToInt32(comboBoxItemId.SelectedValue) : null,
                        comboBoxCageId.SelectedValue != null ? (int?)Convert.ToInt32(comboBoxCageId.SelectedValue) : null,
                        DateTime.Now,
                        numericUpDownDiscount.Value > 0 ? (decimal?)numericUpDownDiscount.Value : null,
                        Convert.ToDecimal(textBoxTotalAmount.Text),
                        Convert.ToDecimal(textBoxNetAmount.Text)
                    );

                await _invoiceService.AddInvoiceAsync(
                    invoice.TreatmentID,
                    invoice.OwnerID,
                    invoice.ConsultationID,
                    invoice.PetID,
                    invoice.ItemID,
                    invoice.CageID,
                    invoice.Date,
                    invoice.Discount,
                    invoice.TotalAmount,
                    invoice.NetAmount
                );

                MessageBox.Show("Invoice created successfully!");
                await LoadInvoiceDataAsync();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating invoice: {ex.Message}");
            }
        }
        public void ResetForm()
        {
            comboBoxOwnerId.SelectedIndex = 0;
            comboBoxPetId.DataSource = null;
            comboBoxConsultationId.DataSource = null;
            comboBoxTreatmentId.DataSource = null;
            comboBoxCageId.DataSource = null;
            comboBoxItemId.SelectedIndex = 0;
            numericUpDownDiscount.Value = 0;
            textBoxTotalAmount.Text = string.Empty;
            textBoxNetAmount.Text = string.Empty;
            _currentTotal = 0;
        }

        public void numericUpDownDiscount_ValueChanged_1(object sender, EventArgs e)
        {
            CalculateNetAmount();

        }

        private void BackButtonInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}


