using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        UserBaseRepository _userBase = new UserBaseRepository();

        private void OpenSignInForm()
        {
            Application.Run(new SignIn());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelError.Hide();
            if (textboxUsername.Text != "" && textBoxPassword1.Text != "" && textBoxPassword2.Text != "")
            {
                if (textboxUsername.Text.Length >= 4)
                {
                    if (textBoxPassword1.Text.Length >= 8)
                    {
                        if (textBoxPassword1.Text == textBoxPassword2.Text)
                        {
                            label4.Text = _userBase.SignUp(textboxUsername.Text, textBoxPassword1.Text).ToString();
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
                        labelError.Text = "Use 8 characters or more for your password";
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
