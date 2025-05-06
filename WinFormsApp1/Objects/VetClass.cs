using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Objects
{
    public class VetClass
    {
        public int VetID { get; set; }
        public string FirstName { get; set; }

        public VetClass(int vetID, string firstName)
        {
            VetID = vetID;
            FirstName = firstName;
        }
    }
}
