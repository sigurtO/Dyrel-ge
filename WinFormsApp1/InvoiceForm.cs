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
        public InvoiceForm(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await LoadInvoiceDataAsync();
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
    }
}
