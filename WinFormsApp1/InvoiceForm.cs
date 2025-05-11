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
        private int _currentTotal = 0;
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
        //starting from here
        private async void comboBoxOwnerId_SelectedIndexChanged(object sender, EventArgs e)
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

                DataTable consultations = await _invoiceService.GetConsultationFromPetDataAsync(ownerId);
                comboBoxConsultationId.DataSource = consultations;
                comboBoxConsultationId.ValueMember = "ConsultationID";
                comboBoxConsultationId.DisplayMember = "Notes";

                _currentTotal = await _invoiceService.CalculateTotalAmount(
                    ownerId,
                    consultations.Rows.Count > 0 ? Convert.ToInt32(consultations.Rows[0]["ConsultationID"]) : 0,
                    0, 0, 0, _currentTotal);

                textBoxTotalAmount.Text = _currentTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private async void comboBoxConsultationId_SelectedIndexChanged(object sender, EventArgs e)
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
                    Convert.ToInt32(comboBoxOwnerId.SelectedValue),
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
                comboBoxCageId.DisplayMember = "DisplayText";
                comboBoxCageId.ValueMember = "CageID";

                _currentTotal = await _invoiceService.CalculateTotalAmount(
                    Convert.ToInt32(comboBoxOwnerId.SelectedValue),
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
        private async void comboBoxItemId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItemId.SelectedValue == null || !(comboBoxItemId.SelectedValue is int itemId) || itemId <= 0)
            {
                return;
            }

            try
            {
                _currentTotal = await _invoiceService.CalculateTotalAmount(
                    comboBoxOwnerId.SelectedValue != null ? Convert.ToInt32(comboBoxOwnerId.SelectedValue) : 0,
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
    }

}
