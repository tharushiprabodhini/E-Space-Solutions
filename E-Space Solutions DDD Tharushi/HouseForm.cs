using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class HouseForm : Form
    {
        string House_id, Number_of_Rooms, Square_of_Feet, Colonist_id;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");


        public HouseForm()
        {
            InitializeComponent();
        }

        public void LoadData() // typing manually this line
        {
            House_id = txt_House_id.Text;
            Number_of_Rooms = txt_NumOfRooms.Text;
            Square_of_Feet = txt_SquareFeet.Text;
            Colonist_id = cmb_ColonistId.Text;
        }

        private void FillComboBox()//typing manually this line
        {
            con.Open();
            string query = "SELECT House_id FROM HouseTable";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmb_Search.Items.Add(read["House_id"].ToString());
            }
            con.Close();
        }


        private void LoadGridView() // typing Manually this line
        {
            con.Open();
            string query = "SELECT * FROM HouseTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGV_House.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
            string update = "UPDATE HouseTable SET Number_of_Rooms = @Number_of_Rooms, Square_of_Feet = @Square_of_Feet, Colonist_id = @Colonist_id " +
                             "WHERE House_id = @House_id";

            using (SqlCommand cmd = new SqlCommand(update, con))
            {
                cmd.Parameters.AddWithValue("@Number_of_Rooms", Number_of_Rooms);
                cmd.Parameters.AddWithValue("@Square_of_Feet", Square_of_Feet);
                cmd.Parameters.AddWithValue("@Colonist_id", Colonist_id);
                cmd.Parameters.AddWithValue("@House_id", House_id);

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
            House_id = txt_House_id.Text;
            string delete = "DELETE FROM HouseTable WHERE House_id = '" + House_id + "'";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadGridView();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            LoadData();
            string Register = "INSERT INTO HouseTable (House_id, Number_of_Rooms, Square_of_Feet, Colonist_id ) " +
                           "VALUES (@House_id, @Number_of_Rooms, @Square_of_Feet, @Colonist_id )";

            using (SqlCommand cmd = new SqlCommand(Register, con))
            {
                cmd.Parameters.AddWithValue("@House_id", House_id);
                cmd.Parameters.AddWithValue("@Number_of_Rooms", Number_of_Rooms);
                cmd.Parameters.AddWithValue("@Square_of_Feet", Square_of_Feet);
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_House_id.Text = "";
            txt_NumOfRooms.Text = "";
            txt_SquareFeet.Text = "";
            cmb_ColonistId.SelectedItem = default;
        }


        private void HouseForm_Load(object sender, EventArgs e)
        {
            LoadGridView();
            FillComboBox();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");//Colonist id Assigning in combo box
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
                    cmb_ColonistId.Items.Add(dr["Colonist_ID"].ToString());
                }
                con.Close();
            }
        }

        private void cmb_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM HouseTable WHERE House_id ='" + cmb_Search.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_House_id.Text = dr["House_id"].ToString();
                txt_NumOfRooms.Text = dr["Number_of_Rooms"].ToString();
                txt_SquareFeet.Text = dr["Square_of_Feet"].ToString();
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
    }
}
