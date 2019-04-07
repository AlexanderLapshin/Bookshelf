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
            label5.Hide();
        }

        UserBaseRepository _userBase = new UserBaseRepository();

        private void OpenSignInForm()
        {
            Application.Run(new SignIn());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Hide();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox1.Text.Length >= 4)
                {
                    if (textBox2.Text.Length >= 8)
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            label4.Text = _userBase.SignUp(textBox1.Text, textBox2.Text).ToString();
                        }
                        else
                        {
                            label5.Show();
                            label5.Text = "Those passwords didn't match. Try again.";
                        }
                    }
                    else
                    {
                        label5.Show();
                        label5.Text = "Use 8 characters or more for your password";
                    }
                }
                else
                {
                    label5.Show();
                    label5.Text = "Use 4 characters or more for your username";
                }
            }
            else
            {
                label5.Show();
                label5.Text = "Fill in all the fields";
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
