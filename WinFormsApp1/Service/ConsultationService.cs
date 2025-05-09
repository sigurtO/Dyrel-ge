using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinFormsApp1.DB;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class ConsultationService : IConsultationService
    {
  
        public async Task<DataTable> LoadConsultationDataAsync()
        {
            try
            {
                return await Program.DbRead.ShowAllConsultationsAsync();
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException("Failed to load consultations", ex);
            }

            
        }


   
        public async Task<DataTable> LoadOwnersAsync()     // load owners into ComboBOx
        {
            try
            {
                DataTable owners = await Program.DbRead.GetOwnersAsync();

                DataRow newRow = owners.NewRow();
                newRow["OwnerID"] = 0;
                newRow["FirstName"] = "-- Select Owner --";
                owners.Rows.InsertAt(newRow, 0);

                return owners;
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException("Failed to load owners", ex);
            }
            

           
        }



        public async Task<DataTable> GetPetsByOwnerAsync(int ownerId)
        {
            if (ownerId <= 0) return null;
            try
            {
                return await Program.DbRead.GetPetsByOwnerAsync(ownerId);
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException($"Failed to load pets for owner {ownerId}", ex);
            }

        }

        public async Task<DataTable> GetVeterinariansByPetAsync(int petId)
        {
            if ( petId <= 0) return null;
            try
            {
                return await Program.DbRead.GetVeterinariansByPetAsync(petId);
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException($"Failed to load vets for pet {petId}", ex);
            }
        }

        //HandleAddConsultationAsync
        public async Task AddConsultationAsync(int ownerId, int petId, int vetId, DateTime date, int price, string notes)
        {
            try
            {
                var consultation = new ConsultationClass(ownerId, petId, vetId, date, price, notes);
                await Program.DbCreate.CreateConsultationAsync(consultation);
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException("Failed to add consultation", ex);
            }
        }

        public async Task DeleteConsultationAsync(int consultationId)
        {
            try
            {
                await Program.DbDelete.DeleteConsultationByIdAsync(consultationId);
            }
            catch (Exception ex)
            {
                throw new ConsultationServiceException($"Failed to delete consultation {consultationId}", ex);
            }
        }



    }
}

// Custom exception class
public class ConsultationServiceException : Exception
{
    public ConsultationServiceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}



//DataTable owners = await Program.DbRead.GetOwnersAsync();
//// Create new 'blank' row
//DataRow newRow = owners.NewRow();
//newRow["OwnerID"] = 0; // id 0 not used in DB
//newRow["FirstName"] = "-- Select Owner --";

//// Insert the new row at the top of the table
//owners.Rows.InsertAt(newRow, 0);



//// Set the ComboBox's DataSource
//comboBox.DataSource = owners;
//comboBox.DisplayMember = "FirstName"; // Column to display
//comboBox.ValueMember = "OwnerID"; // Column to store as values;




//if (comboBoxOwner.SelectedItem == null) return; //skip if no item selected

//var selectedRow = (DataRowView)comboBoxOwner.SelectedItem; // Get the bound row 
//int selectedOwnerID = Convert.ToInt32(selectedRow["OwnerID"]); // Extract the ID //Some 'Error' with SelectedValue in winforms
//                                                               // SelectedItem more consistent
//if (selectedOwnerID == 0) // blank row 
//{
//    comboBoxVet.DataSource = null;
//    comboBoxPet.DataSource = null;
//}
//else
//{
//    comboBoxPet.DataSource = await Program.DbRead.GetPetsByOwnerAsync(selectedOwnerID);
//    comboBoxPet.DisplayMember = "Name";
//    comboBoxPet.ValueMember = "PetID";
//    comboBoxVet.DataSource = null;
//}


//if (comboPet.SelectedValue == null || comboPet.DataSource == null)
//{
//    comboVet.DataSource = null;
//    return;
//}

//int? selectedPetID = comboPet.SelectedValue as int?;
//comboVet.DataSource = await Program.DbRead.GetVeterinariansByPetAsync(selectedPetID);
//comboVet.DisplayMember = "FirstName";
//comboVet.ValueMember = "PetDocID";