using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Objects;
using WinFormsApp1.Service;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{

    public partial class Consultation : Form
    {
        private ConsultationService consultationService = new ConsultationService();
        public Consultation()
        {
            InitializeComponent();
            // constructor cannot be async
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // loads UI
            try
            {
                await consultationService.LoadConsultationDataAsync(dataGridView); // Load the data into the DataGridView
                await consultationService.LoadOwnersAsync(comboBoxOwner);// Populate the ComboBox
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load Data");
            }

        }


        private async void comboBoxOwner_SelectedIndexChanged(object sender, EventArgs e) //Index changed in Owner box
        {
            await consultationService.OnOwnerChangedUpdatePetAsync(comboBoxOwner, comboBoxVet, comboBoxPet);
        }

        private async void comboBoxPet_SelectedIndexChanged(object sender, EventArgs e) //Index changed in Pet box
        {
            await consultationService.OnPetChangedUpdateVetAsync(comboBoxPet, comboBoxVet);
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            await consultationService.HandleAddConsultationAsync(comboBoxOwner, comboBoxPet, comboBoxVet, textBoxDate, textBoxNotes, textBoxPrice);
            await consultationService.LoadConsultationDataAsync(dataGridView); // Refresh the DataGridView
            MessageBox.Show("Consultation created successfully!");

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await consultationService.DeleteConsultationAsync(dataGridView);
            await consultationService.LoadConsultationDataAsync(dataGridView);
        }
    }
}
