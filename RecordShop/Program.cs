using RecordShop.Views;

namespace RecordShop
{
    internal static class Program
    {
        public static Login login;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            login = new Login();
            Application.Run(login);
        }
    }
}