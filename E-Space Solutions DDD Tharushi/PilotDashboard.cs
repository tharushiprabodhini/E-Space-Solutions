using System;
using System.Windows.Forms;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class PilotDashboard : Form
    {
        public PilotDashboard()
        {
            InitializeComponent();
        }

        private void btn_trip_Click(object sender, EventArgs e)
        {
            Pilot_TripForm pilot_TripForm = new Pilot_TripForm();
            this.Hide();
            pilot_TripForm.Show();
        }

        private void btn_Ejet_Click(object sender, EventArgs e)
        {
            Pilot_EjetForm pilot_EjetForm = new Pilot_EjetForm();
            this.Hide();
            pilot_EjetForm.Show();
        }

        private void LinkLabel_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectLoginTypeForm selectLoginTypeForm = new SelectLoginTypeForm();
            this.Hide();
            selectLoginTypeForm.Show();
        }

    }
}
