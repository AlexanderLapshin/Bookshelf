using Data;
using Data.Exceptions;
using Models;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MoneyFlow
{
    public partial class SignIn : Form
    {
        private UserController _userBase = new UserController();
        private User user;
        private string username;

        public SignIn()
        {
            InitializeComponent();
        }

        private void OpenSignUpForm()
        {
            Application.Run(new SignUp());
        }

        private void OpenMainForm()
        {
            Application.Run(new MainForm(user));
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

            if (bunifuTextBoxSignInUsername.Text.Length >= 4 && bunifuTextBoxSignInPassword.Text.Length >= 8)
            {
                try
                {
                    user = _userBase.SignIn(bunifuTextBoxSignInUsername.Text, bunifuTextBoxSignInPassword.Text);
                    username = bunifuTextBoxSignInUsername.Text;
                    if (user != null)
                    {
                        Close();
                        Thread td = new Thread(OpenMainForm);
                        td.Start();
                    }
                }
                catch (InvalidUsernameException error)
                {
                    labelSignInError.Text = error.Message;
                    bunifuTransition1.Show(labelSignInError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                catch (InvalidPasswordException error)
                {
                    labelSignInError.Text = error.Message;
                    bunifuTransition1.Show(labelSignInError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
            }
            else
            {
                labelSignInError.Text = "Login Failed";
                bunifuTransition1.Show(labelSignInError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            }
        }

        private void linkLabelSignInSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Thread td = new Thread(OpenSignUpForm);
            td.Start();
        }
    }
}
