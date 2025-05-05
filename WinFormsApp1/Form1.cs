namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Main Main = new Main();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Main.Show();
            this.Hide();
        }
    }
}
