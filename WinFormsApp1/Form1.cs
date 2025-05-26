using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Service;
using WinFormsApp1.DB.DbRead;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly LoginService _loginService;

        public Form1()
        {
            InitializeComponent();

            _loginService = new LoginService();
        }
        //Tolu
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            // buttonLogin.Enabled = false;
            try
            {
                bool success = await _loginService.AuthenticateAsync(username, password);

                if (success)
                {
                    new Main().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}