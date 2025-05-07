using WinFormsApp1.DB;

namespace WinFormsApp1
{
    internal static class Program
    {
        public static DbRead DbRead { get; private set; }
        public static DbCreate DbCreate { get; private set; }
        public static DbDelete DbDelete { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string connectionString = "Data Source=SQL6032.site4now.net;Initial Catalog=db_ab8928_vet;User Id=db_ab8928_vet_admin;Password=Admin1234";

            DbRead = new DbRead(connectionString);
            DbCreate = new DbCreate(connectionString);
            DbDelete = new DbDelete(connectionString);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}