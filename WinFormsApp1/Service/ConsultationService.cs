using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class ConsultationService
    {
  
        public async Task LoadConsultationDataAsync(DataGridView gridView)       //Load the data into the DataGridView
        {
            try
            {
                DataTable consultations = await Program.DbRead.ShowAllConsultationsAsync();
                gridView.DataSource = consultations;
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load consultations:");
                gridView.DataSource = null; // Clear the DataGridView
            }

            
        }


   
        public async Task LoadOwnersAsync(ComboBox comboBox)     // load owners into ComboBOx
        {
            try
            {
                DataTable owners = await Program.DbRead.GetOwnersAsync();
                // Create new 'blank' row
                DataRow newRow = owners.NewRow();
                newRow["OwnerID"] = 0; // id 0 not used in DB
                newRow["FirstName"] = "-- Select Owner --";

                // Insert the new row at the top of the table
                owners.Rows.InsertAt(newRow, 0);



                // Set the ComboBox's DataSource
                comboBox.DataSource = owners;
                comboBox.DisplayMember = "FirstName"; // Column to display
                comboBox.ValueMember = "OwnerID"; // Column to store as value
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load owners:");
                comboBox.DataSource = null; // Clear the ComboBox
            }
            

           
        }



        public async Task OnOwnerChangedUpdatePetAsync(ComboBox comboBoxOwner, ComboBox comboBoxVet, ComboBox comboBoxPet)
        {

            if (comboBoxOwner.SelectedItem == null) return; //skip if no item selected

            var selectedRow = (DataRowView)comboBoxOwner.SelectedItem; // Get the bound row 
            int selectedOwnerID = Convert.ToInt32(selectedRow["OwnerID"]); // Extract the ID //Some 'Error' with SelectedValue in winforms
                                                                                            // SelectedItem more consistent
            if (selectedOwnerID == 0) // blank row 
            {
                comboBoxVet.DataSource = null;
                comboBoxPet.DataSource = null;
            }
            else
            {
                comboBoxPet.DataSource = await Program.DbRead.GetPetsByOwnerAsync(selectedOwnerID);
                comboBoxPet.DisplayMember = "Name";
                comboBoxPet.ValueMember = "PetID";
                comboBoxVet.DataSource = null;
            }
        }

        public async Task OnPetChangedUpdateVetAsync(ComboBox comboPet, ComboBox comboVet)
        {
            if (comboPet.SelectedValue == null || comboPet.DataSource == null)
            {
                comboVet.DataSource = null;
                return;
            }

            int? selectedPetID = comboPet.SelectedValue as int?;
            comboVet.DataSource = await Program.DbRead.GetVeterinariansByPetAsync(selectedPetID);
            comboVet.DisplayMember = "FirstName";
            comboVet.ValueMember = "PetDocID";
        }


        public async Task HandleAddConsultationAsync(ComboBox comboOwner, ComboBox comboPet, ComboBox comboVet, DateTimePicker dateBox, RichTextBox notesBox, NumericUpDown priceBox)
        {
            int Owner = Convert.ToInt32(comboOwner.SelectedValue);
            int Pet = Convert.ToInt32(comboPet.SelectedValue);
            int Vet = Convert.ToInt32(comboVet.SelectedValue);
            DateTime date = dateBox.Value;
            string notes = notesBox.Text;
            int price = (int)priceBox.Value;

            ConsultationClass NewConsultation = new ConsultationClass(Owner, Pet, Vet, date, price, notes);
            await Program.DbCreate.CreateConsultationAsync(NewConsultation);
        }


    }
}
