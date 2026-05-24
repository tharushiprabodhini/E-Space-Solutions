using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class TripForm : Form
    {
        string Trip_id, Jet_id, Pilot_id, Colonist_id;
        DateTime Launch_Date, Return_Date;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");
        string connectionString = (@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

        public TripForm()
        {
            InitializeComponent();
        }

        public void LoadData() // typing manually this line
        {
            Trip_id = txt_TripId.Text;
            Launch_Date = Dtp_LaunchDate.Value.Date;
            Return_Date = Dtp_ReturnDate.Value.Date;
            Jet_id = cmb_Jet_id.Text;
            Pilot_id = cmb_Pilot_id.Text;
            Colonist_id = cmb_ColonistId.Text;
        }


        private void FillComboBox()//typing manually this line
        {
            con.Open();
            string query = "SELECT Trip_id FROM TripTable";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmb_Search.Items.Add(read["Trip_id"].ToString());
            }
            con.Close();
        }


        private void LoadGridView() // typing Manually this line
        {
            con.Open();
            string query = "SELECT * FROM TripTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGV_Trip.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void TripForm_Load(object sender, EventArgs e)
        {
            LoadGridView();
            FillComboBox();

            using (SqlConnection con = new SqlConnection(connectionString)) //Jet id Assigning in combo box
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM JetTable";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmb_Jet_id.Items.Add(dr["Jet_id"].ToString());
                }
                con.Close();
            }

            using (SqlConnection con = new SqlConnection(connectionString))//Pilot id Assigning in combo box
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PilotTable";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmb_Pilot_id.Items.Add(dr["Pilot_id"].ToString());
                }
                con.Close();
            }

            using (SqlConnection con = new SqlConnection(connectionString))//Colonist id Assigning in combo box
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ColonistTable";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmb_ColonistId.Items.Add(dr["Colonist_id"].ToString());
                }
                con.Close();
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
            string update = "UPDATE TripTable SET Launch_Date = @Launch_Date, Return_Date = @Return_Date, Jet_id = @Jet_id, " +
                                    "Pilot_id = @Pilot_id, Colonist_id = @Colonist_id WHERE Trip_id = @Trip_id";
            using (SqlCommand cmd = new SqlCommand(update, con))
            {
                cmd.Parameters.AddWithValue("@Launch_Date", Launch_Date);
                cmd.Parameters.AddWithValue("@Return_Date", Return_Date);
                cmd.Parameters.AddWithValue("@Jet_id", Jet_id);
                cmd.Parameters.AddWithValue("@Pilot_id", Pilot_id);
                cmd.Parameters.AddWithValue("@Colonist_id", Colonist_id);
                cmd.Parameters.AddWithValue("@Trip_id", Trip_id);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
                LoadGridView();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            Trip_id = txt_TripId.Text;
            string delete = "DELETE FROM TripTable WHERE Trip_id = '" + Trip_id + "'";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadGridView();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_TripId.Text = "";
            Dtp_LaunchDate.Text = default;
            Dtp_ReturnDate.Text = default;
            cmb_Jet_id.SelectedItem = default;
            cmb_Pilot_id.SelectedItem = default;
            cmb_ColonistId.SelectedItem = default;
        }

        private void cmb_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TripTable WHERE Trip_id ='" + cmb_Search.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_TripId.Text = dr["Trip_id"].ToString();
                Dtp_LaunchDate.Text = dr["Launch_Date"].ToString();
                Dtp_ReturnDate.Text = dr["Return_Date"].ToString();
                cmb_Jet_id.Text = dr["Jet_id"].ToString();
                cmb_Pilot_id.Text = dr["Pilot_id"].ToString();
                cmb_ColonistId.Text = dr["Colonist_id"].ToString();
            }
            con.Close();
        }


        private void linkLabel_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure, want to Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel_BackDshbrd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Hide();
            adminDashboard.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            LoadData();
            string Register = "INSERT INTO TripTable (Trip_id, Launch_Date, Return_Date, Jet_id, Pilot_id, Colonist_id ) " +
                           "VALUES (@Trip_id, @Launch_Date, @Return_Date, @Jet_id, @Pilot_id, @Colonist_id )";

            using (SqlCommand cmd = new SqlCommand(Register, con))
            {
                cmd.Parameters.AddWithValue("@Trip_id", Trip_id);
                cmd.Parameters.AddWithValue("@Launch_Date", Launch_Date);
                cmd.Parameters.AddWithValue("@Return_Date", Return_Date);
                cmd.Parameters.AddWithValue("@Jet_id", Jet_id);
                cmd.Parameters.AddWithValue("@Pilot_id", Pilot_id);
                cmd.Parameters.AddWithValue("@Colonist_id", Colonist_id);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
                LoadGridView();
            }
        }
    }
}
