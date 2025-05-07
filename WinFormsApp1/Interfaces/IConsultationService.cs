using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Interfaces
{
    public interface IConsultationService
    {
        Task LoadConsultationDataAsync(DataGridView gridView);
        Task LoadOwnersAsync(ComboBox comboBox);
        Task OnOwnerChangedUpdatePetAsync(ComboBox comboBoxOwner, ComboBox comboBoxVet, ComboBox comboBoxPet);
        Task OnPetChangedUpdateVetAsync(ComboBox comboPet, ComboBox comboVet);
        Task HandleAddConsultationAsync(ComboBox comboOwner, ComboBox comboPet, ComboBox comboVet, DateTimePicker dateBox, RichTextBox notesBox, NumericUpDown priceBox);
        Task DeleteConsultationAsync(DataGridView grid);
    }
}
