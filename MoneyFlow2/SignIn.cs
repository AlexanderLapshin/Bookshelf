﻿using Data;
using Data.Exceptions;
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

        private UserController _userBase = new UserController();
        private int userID;
        private string username;


        private void OpenSignUpForm()
        {
            Application.Run(new SignUp());
        }

        private void OpenMainForm()
        {
            Application.Run(new MainForm(userID, username));
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Thread td = new Thread(OpenSignUpForm);
            td.Start();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            labelError.Hide();
            if (textBoxUsername.Text.Length >= 4 && textBoxPassword.Text.Length >= 8)
            {
                try
                {
                    //userID = _userBase.SignIn(textBoxUsername.Text, textBoxPassword.Text);
                    username = textBoxUsername.Text;
                    if (userID != 0)
                    {
                        Close();
                        Thread td = new Thread(OpenMainForm);
                        td.Start();
                    }
                }
                catch (InvalidUsernameException error)
                {
                    labelError.Show();
                    labelError.Text = error.Message;
                }
                catch (InvalidPasswordException error)
                {
                    labelError.Show();
                    labelError.Text = error.Message;
                }
            }
            else
            {
                labelError.Show();
                labelError.Text = "Login Failed";
            }
        }
    }
}
