using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Objects
{
    public class PetClass
    {
        public int OwnerID { get; set; }

        public int? PetDocID { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Species { get; set; }

        public string Breed { get; set; }

        public PetClass(int ownerID, int petDocID, string name, DateTime birthday, string species, string breed)
        {
            OwnerID = ownerID;
            PetDocID = petDocID;
            Name = name;
            Birthday = birthday;
            Species = species;
            Breed = breed;
        }
        public PetClass()
        {
            
        }
    }
   
}

