using Data;
using System;
using System.Windows.Forms;

namespace Bookshelf
{
    static class Program
    {
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
            //Application.Run(new MainForm(1, "TEST"));

            Application.Run(new SignIn());


        }
    }

}
