using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class ColonistViewDetailsForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string connectionString = (@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

        public ColonistViewDetailsForm()
        {
            InitializeComponent();
        }

        private void linkLabel_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void Colonist_Details_GridView()
        {
            string query = "SELECT* FROM ColonistTable ORDER BY Colonist_id ASC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                // Bind the data to the DataGridView
                DGV_ViewColnyDetails.DataSource = dt;
            }
        }

        public void Trip_Details_GridView()
        {
            string query = "SELECT* FROM TripTable ORDER BY Trip_id ASC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                // Bind the data to the DataGridView
                DGV_ViewTripDetails.DataSource = dt;
            }
        }

        public void House_Details_GridView()
        {
            string query = "SELECT* FROM HouseTable ORDER BY House_id ASC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                // Bind the data to the DataGridView
                DGV_ViewHouseDetails.DataSource = dt;
            }
        }

        public void Ejet_Details_GridView()
        {
            string query = "SELECT* FROM JetTable ORDER BY Jet_id ASC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                // Bind the data to the DataGridView
                DGV_ViewEjetDetails.DataSource = dt;
            }
        }


        public void Job_Details_GridView()
        {
            string query = "SELECT* FROM JobTable ORDER BY Job_id ASC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                // Bind the data to the DataGridView
                DGV_ViewJobDetails.DataSource = dt;
            }
        }


        private void linkLabel_Exit_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure, want to Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ColonistViewDetailsForm_Load(object sender, EventArgs e)
        {
            Colonist_Details_GridView();
            Trip_Details_GridView();
            House_Details_GridView();
            Ejet_Details_GridView();
            Job_Details_GridView();
        }

        private void linkLabel_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectLoginTypeForm selectLoginTypeForm = new SelectLoginTypeForm();
            this.Hide();
            selectLoginTypeForm.Show();
        }
    }
}
