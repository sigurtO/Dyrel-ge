using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Objects
{
    public class TreatmentClass
    {
        public int OwnerID { get; set; }
        public int PetDocID { get; set; }
        public int PetID { get; set; }
        public int ConsultationID { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public TreatmentClass(int ownerId, int petDocId, int consultationId, int price, DateTime date, string notes, int petID)
        {
            OwnerID = ownerId;
            PetDocID = petDocId;
            ConsultationID = consultationId;
            Price = price;
            Date = date;
            Notes = notes;
            PetID = petID;
        }
        public TreatmentClass()
        {
            
        }
    }
}
