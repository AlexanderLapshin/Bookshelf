using System;
using System.Windows.Forms;

namespace MoneyFlow
{
    public partial class MainForm : Form
    {
        public MainForm(int userID)
        {
            InitializeComponent();
        }

        private void buttonMainFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMainFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
