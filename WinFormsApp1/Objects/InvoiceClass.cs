using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Objects
{
    public class InvoiceClass
    {
        public class Invoice
        {
            public int? TreatmentID { get; set; } // can be null
            public int OwnerID { get; set; }
            public int? ConsultationID { get; set; } // can be null
            public int PetID { get; set; }
            public int? ItemID { get; set; } // can be null
            public int? CageID { get; set; } // can be null
            public DateTime Date { get; set; }
            public decimal? Discount { get; set; } // Can be percentage or fixed amount also can be null
            public decimal TotalAmount { get; set; }
            public decimal NetAmount { get; set; }




        }
    }
}
