using Bunifu.UI.WinForms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MoneyFlow
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void OpenSignUpForm()
        {
            Application.Run(new SignUp());
        }

        private void buttonSignInClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignInMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(labelSignInError, true, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            BunifuTransition transition = new BunifuTransition();
            transition.Interval = 10;
            bunifuTransition1.Show(labelSignInError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
        }

        private void linkLabelSignInSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Thread td = new Thread(OpenSignUpForm);
            td.Start();
        }
    }
}
