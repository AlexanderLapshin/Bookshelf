using Data;
using Data.Exceptions;
using Models;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace MoneyFlow
{
    public partial class SignUp : Form
    {
        private UserController _userBase = new UserController();
        private User user;
        const string usernameRegexPattern = @"^[a-zA-Z][a-zA-Z0-9-_\.]{3,20}$";
        const string passwordRegexPattern = @"^(((?=.*[a-z])(?=.*[A-Z]))|((?=.*[a-z])(?=.*[0-9]))|((?=.*[A-Z])(?=.*[0-9])))(?=.{5,64})";

        public SignUp()
        {
            InitializeComponent();
        }

        private void OpenSignInForm()
        {
            Application.Run(new SignIn());
        }


        private void OpenMainForm()
        {
            Application.Run(new MainForm(user));
        }

        private void buttonSignUpClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignUpMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButtonSignUpNext_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(labelSignUpError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            if (bunifuTextBoxSignUpUsername.Text != "" && bunifuTextBoxSignUpPassword.Text != "" && bunifuTextBoxSignUpPassword2.Text != "")
            {

                if (Regex.IsMatch(bunifuTextBoxSignUpUsername.Text, usernameRegexPattern))
                {
                    if (Regex.IsMatch(bunifuTextBoxSignUpPassword.Text, passwordRegexPattern))
                    {
                        if (bunifuTextBoxSignUpPassword.Text == bunifuTextBoxSignUpPassword2.Text)
                        {
                            if (_userBase.isUsernameFree(bunifuTextBoxSignUpUsername.Text))
                            {
                                bunifuPages1.SetPage(1);
                            }
                            else
                            {
                                labelSignUpError.Text = "Username already exists";
                                bunifuTransition1.Show(labelSignUpError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                            }
                        }
                        else
                        {
                            labelSignUpError.Text = "Passwords didn't match";
                            bunifuTransition1.Show(labelSignUpError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                        }
                    }
                    else
                    {
                        labelSignUpError.Text = "Invalid password";
                        bunifuTransition1.Show(labelSignUpError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    }
                }
                else
                {
                    labelSignUpError.Text = "Invalid username";
                    bunifuTransition1.Show(labelSignUpError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
            }
            else
            {
                labelSignUpError.Text = "Enter all the fields";
                bunifuTransition1.Show(labelSignUpError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            }
        }

        private void linkLabelSignUpSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Thread td = new Thread(OpenSignInForm);
            td.Start();
        }

        private void bunifuButtonSignUpFinishSetup_Click(object sender, EventArgs e)
        {
            if (bunifuTextBoxSignUpFirstName.Text != "" && bunifuTextBoxSignUpLastName.Text != "")
            {
                try
                {
                    user = _userBase.SignUp(bunifuTextBoxSignUpUsername.Text, bunifuTextBoxSignUpPassword.Text, bunifuTextBoxSignUpFirstName.Text, bunifuTextBoxSignUpLastName.Text);
                    Close();
                    Thread td = new Thread(OpenMainForm);
                    td.Start();
                }
                catch (InvalidUsernameException exc)
                {
                    labelSignUpError.Text = exc.Message;
                    bunifuTransition1.Show(labelSignUpError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                catch
                {
                    labelSignUpError2.Text = "Something went wrong";
                    bunifuTransition1.Show(labelSignUpError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
            }
            else
            {
                labelSignUpError2.Text = "Enter all the fields";
                bunifuTransition1.Show(labelSignUpError, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            }
        }
    }
}
