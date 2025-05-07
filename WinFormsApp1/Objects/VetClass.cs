using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Objects
{
    public class VetClass
    {
        public int PetDocID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Speciale { get; set; }


        public VetClass(int petDocID, string firstName,string lastname, string username, string passwordHash, string speciale)
        {
            PetDocID = petDocID;
            FirstName = firstName;
            LastName = lastname;
            Username = username;
            PasswordHash = passwordHash;
            Speciale = speciale;
        }
    }
}
