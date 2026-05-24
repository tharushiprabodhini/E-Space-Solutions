using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }


        private void btn_colonist_Click(object sender, EventArgs e)
        {
            ColonistForm colonistForm = new ColonistForm();
            this.Hide();
            colonistForm.Show();
        }

        private void btn_dependent_Click(object sender, EventArgs e)
        {
            DependentForm dependentForm = new DependentForm();
            this.Hide();
            dependentForm.Show();
        }

        private void btn_pilot_Click(object sender, EventArgs e)
        {
            PilotForm pilotForm = new PilotForm();
            this.Hide();
            pilotForm.Show();
        }


        private void btn_house_Click(object sender, EventArgs e)
        {
            HouseForm houseForm = new HouseForm();
            this.Hide();
            houseForm.Show();
        }

        private void btn_Ejet_Click(object sender, EventArgs e)
        {
            E_JetForm e_JetForm = new E_JetForm();
            this.Hide();
            e_JetForm.Show();
        }

        private void btn_job_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm();
            this.Hide();
            jobForm.Show();
        }

        private void btn_trip_Click(object sender, EventArgs e)
        {
            TripForm tripForm = new TripForm();
            this.Hide();
            tripForm.Show();
        }

       

        private void linkLabel_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectLoginTypeForm selectLoginTypeForm = new SelectLoginTypeForm();
            this.Hide();
            selectLoginTypeForm.Show();
        }



        private void lbl_DataEnyOper_Click(object sender, EventArgs e)
        {

        }
    }
}
