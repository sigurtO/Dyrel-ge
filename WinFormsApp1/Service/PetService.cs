using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class PetService
    {
        public async Task LoadPetDataAsync(DataGridView gridView)       //Load the data into the DataGridView
        {
            try
            {
                DataTable pet = await Program.dbServices.DbReadPet.ShowAllPetAsync();
                gridView.DataSource = pet;
            }
            catch (Exception)
            {
                MessageBox.Show("Error:: Failed to load pet:");
                gridView.DataSource = null; // Clear the DataGridView
            }
        }

        public async Task HandleAddPetAsync(TextBox PetNameTextBox, DateTimePicker petDateTimePicker, TextBox PetBreedTextBox, TextBox PetSpeciesTextBox, TextBox PetOwnerTextBox, TextBox PetDocIDTextBox )
        {
            try
            {
                string Name = PetNameTextBox.Text;
                DateTime Birthday = petDateTimePicker.Value;
                string Breed = PetBreedTextBox.Text;
                string Species = PetSpeciesTextBox.Text;
                int OwnerID = Convert.ToInt32 (PetOwnerTextBox.Text);
                int DocID = Convert.ToInt32 (PetDocIDTextBox.Text);
               
               
                PetClass newPet = new PetClass(OwnerID, DocID, Name, Birthday, Species, Breed);
                await Program.dbServices.DbCreatePet.AddPetAsync(newPet);
            }
            catch
            {
                MessageBox.Show("Error:: Failed to add pet ");
            }
        }
    }
}

