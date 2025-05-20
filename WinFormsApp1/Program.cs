using WinFormsApp1.DB;
using WinFormsApp1.Service;

namespace WinFormsApp1
{
    internal static class Program
    {
       public static DbService dbServices { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string connectionString = "Server=SQL6032.site4now.net;Database=db_ab8928_vet;User Id=db_ab8928_vet_admin;Password=Admin1234;TrustServerCertificate=True;";


            dbServices = new DbService(connectionString);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}