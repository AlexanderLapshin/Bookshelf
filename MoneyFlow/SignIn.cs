using Bunifu.UI.WinForms;
using System;
using System.Windows.Forms;

namespace MoneyFlow
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(label3, true, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            BunifuTransition transition = new BunifuTransition();
            //transition.TimeStep = 0.001F;
            transition.Interval = 10;
            //bunifuTransition1.MaxAnimationTime = 100000;
            bunifuTransition1.Show(label3, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
        }
    }
}
