using Data;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Bookshelf
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            labelError.Hide();
        }

        private UserBaseRepository _userBase = new UserBaseRepository();
        private int userId;
        private string username;
        string usernameRegexPattern = @"^[a-zA-Z][a-zA-Z0-9-_\.]{4,20}$";
        string passwordRegexPattern = @"^(((?=.*[a-z])(?=.*[A-Z]))|((?=.*[a-z])(?=.*[0-9]))|((?=.*[A-Z])(?=.*[0-9])))(?=.{6,64})";


        private void OpenSignInForm()
        {
            Application.Run(new SignIn());
        }

        private void OpenMainForm()
        {
            Application.Run(new MainForm(userId, username));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelError.Hide();
            if (textboxUsername.Text != "" && textBoxPassword1.Text != "" && textBoxPassword2.Text != "")
            {

                if (Regex.IsMatch(textboxUsername.Text, usernameRegexPattern))
                {
                    if (Regex.IsMatch(textBoxPassword1.Text, passwordRegexPattern))
                    {
                        if (textBoxPassword1.Text == textBoxPassword2.Text)
                        {
                            try
                            {
                                userId = _userBase.SignUp(textboxUsername.Text, textBoxPassword1.Text);
                                username = textboxUsername.Text;
                                Close();
                                Thread td = new Thread(OpenMainForm);
                                td.Start();
                            }
                            catch
                            {
                                labelError.Show();
                                labelError.Text = "Something went wrong. Try again later.";
                            }
                        }
                        else
                        {
                            labelError.Show();
                            labelError.Text = "Those passwords didn't match. Try again.";
                        }
                    }
                    else
                    {
                        labelError.Show();
                        labelError.Text = "Use 6 characters or more for your password";
                    }
                }
                else
                {
                    labelError.Show();
                    labelError.Text = "Use 4 characters or more for your username";
                }
            }
            else
            {
                labelError.Show();
                labelError.Text = "Fill in all the fields";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Thread td = new Thread(OpenSignInForm);
            td.Start();
        }
    }
}
