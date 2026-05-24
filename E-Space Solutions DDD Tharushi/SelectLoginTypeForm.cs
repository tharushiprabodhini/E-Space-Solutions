using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class SelectLoginTypeForm : Form
    {
        public SelectLoginTypeForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, want to Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            this.Hide();
            adminLoginForm.Show();
        }

        private void btn_Pilot_Click(object sender, EventArgs e)
        {
            PilotLoginForm pilotLoginForm = new PilotLoginForm();
            this.Hide();
            pilotLoginForm.Show();
        }

        private void btn_Colonist_Click(object sender, EventArgs e)
        {
            ColonistLoginForm colonistLoginForm = new ColonistLoginForm();
            this.Hide();
            colonistLoginForm.Show();
        }

        private void SelectLoginTypeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
