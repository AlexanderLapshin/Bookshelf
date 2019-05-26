using System;
using System.Threading;
using System.Windows.Forms;

namespace MoneyFlow
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void OpenSignInForm()
        {
            Application.Run(new SignIn());
        }


        private void buttonSignUpClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignUpMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabelSignUpSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Thread td = new Thread(OpenSignInForm);
            td.Start();
        }
    }
}
