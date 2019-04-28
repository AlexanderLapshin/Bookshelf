using Data;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Bookshelf
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            labelError.Hide();
        }

        private UserBaseRepository _userBase = new UserBaseRepository();
        private int userID = 0;


        private void OpenSignUpForm()
        {
            Application.Run(new SignUp());
        }

        private void OpenMainForm()
        {
            Application.Run(new MainForm(userID));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Thread td = new Thread(OpenSignUpForm);
            td.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelError.Hide();
            if (textBoxUsername.Text.Length >= 4 && textBoxPassword.Text.Length >= 8)
            {
                try
                {
                    userID = _userBase.SignIn(textBoxUsername.Text, textBoxPassword.Text);
                    if (userID != 0)
                    {
                        Close();
                        Thread td = new Thread(OpenMainForm);
                        td.Start();
                    }
                }
                catch (UnauthorizedAccessException error)
                {
                    labelError.Show();
                    labelError.Text = error.Message;
                }
                catch (InvalidOperationException error)
                {
                    labelError.Show();
                    labelError.Text = "Username doesn't exist";
                }
            }
            else
            {
                labelError.Show();
                labelError.Text = "Incorrect input";
            }
        }
    }
}
