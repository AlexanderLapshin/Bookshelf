using System;
using System.Windows.Forms;

namespace Bookshelf
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm(1, "TEST"));
            Application.Run(new SignIn());
        }
    }
}
