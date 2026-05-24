using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class Pilot_EjetForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string connectionString = (@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

        public Pilot_EjetForm()
        {
            InitializeComponent();
        }

        public void Pilot_Ejet_Details_GridView()
        {
            string query = "SELECT* FROM JetTable ORDER BY Jet_id ASC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                // Bind the data to the DataGridView
                DataGridView_EjetDetails.DataSource = dt;
            }
        }


        private void linkLabel_BackDshbrd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PilotDashboard pilotDashboard = new PilotDashboard();
            this.Hide();
            pilotDashboard.Show();
        }

        private void linkLabel_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure, want to Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Pilot_EjetForm_Load(object sender, System.EventArgs e)
        {
            Pilot_Ejet_Details_GridView();
        }
    }
}
