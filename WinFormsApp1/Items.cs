using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1
{
    public partial class Items : Form
    {

        private readonly IitemService _itemService;
        public Items(IitemService iitemService)
        {
            _itemService = iitemService;
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await LoadItemsAsync();
        }
        private async Task LoadItemsAsync()
        {
            try
            {
                dataGridViewItems.DataSource = await _itemService.LoadItemDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading consultations: {ex.Message}");
            }
        }

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloadsPath, "export.txt");
            _itemService.ExportToTextFile(dataGridViewItems, filePath);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
