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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        UserBaseRepository _userBase = new UserBaseRepository();

        private void OpenSignUpForm()
        {
            Application.Run(new SignUp());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Thread td = new Thread(OpenSignUpForm);
            td.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_userBase.SignIn(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("OK");
            }
        }
    }
}
