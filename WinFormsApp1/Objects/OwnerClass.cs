using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Objects
{
    public class OwnerClass
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        public string Adress { get; set; }

        public OwnerClass(string firstName, string lastName, string email, int phone, string adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Adress = adress;
        }

        public OwnerClass()
        {
        }
    }
}
