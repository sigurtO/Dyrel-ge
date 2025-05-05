using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        Consultation Consultation = new Consultation();
        public Main()
        {
            InitializeComponent();
        }

        private void buttonConsultation_Click(object sender, EventArgs e)
        {
            Consultation.Show();
            this.Hide();
        }
    }
}
