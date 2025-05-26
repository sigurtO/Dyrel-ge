using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Objects
{

    public class ConsultationClass
    {
        public int OwnerID { get; set; }
        public int PetID { get; set; }
        public int VetID { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public string Notes { get; set; }

        public ConsultationClass(int ownerID, int petID, int vetID, DateTime date, int price, string notes)
        {
            OwnerID = ownerID;
            PetID = petID;
            VetID = vetID;
            Date = date;
            Price = price;
            Notes = notes;
        }
    }
}


