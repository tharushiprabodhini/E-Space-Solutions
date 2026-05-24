using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class PilotMangeProfileForm : Form
    {
        public PilotMangeProfileForm()
        {
            InitializeComponent();
        }

        private void chK_Password_CheckedChanged(object sender, EventArgs e)
        {
            txt_NewPassword.PasswordChar = chK_Password.Checked ? '\0' : '•';
        }

        private void chK_ShowSecondPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_ConfirmPassword.PasswordChar = chK_ShowSecondPassword.Checked ? '\0' : '•';
        }

        private void linkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PilotDashboard pilotDashboard = new PilotDashboard();
            this.Hide();
            pilotDashboard.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txt_NewPassword.Text = "";
        }

        private void btn_ClearPassword_Click(object sender, EventArgs e)
        {
            txt_ConfirmPassword.Text = "";
        }
    }
}
