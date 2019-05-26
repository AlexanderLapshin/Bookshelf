using Data;
using System;
using System.Windows.Forms;

namespace MoneyFlow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create database
            using (var client = new MoneyFlowDbContext())
            {
                client.Database.CreateIfNotExists();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
    }
}
