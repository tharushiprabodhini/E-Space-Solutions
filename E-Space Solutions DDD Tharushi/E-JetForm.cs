using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class E_JetForm : Form
    {
        string Jet_id, Made_Year, Jet_Type, Power_source, Num_of_Seats, Weight;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");


        public E_JetForm()
        {
            InitializeComponent();
        }

        public void LoadData() // typing manually this line
        {
            Jet_id = txt_JetId.Text;
            Made_Year = txt_MadeYear.Text;
            Jet_Type = cmb_JetType.Text;
            Power_source = cmb_PowerSource.Text;
            Num_of_Seats = txt_NumOfPassnSeats.Text;
            Weight = txt_Weight.Text;
        }

        private void FillComboBox()//typing manually this line
        {
            con.Open();
            string query = "SELECT Jet_id FROM JetTable";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmb_Search.Items.Add(read["Jet_id"].ToString());
            }
            con.Close();
        }

        private void LoadGridView() // typing Manually this line
        {
            con.Open();
            string query = "SELECT * FROM JetTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGV_EJet.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }


        private void E_JetForm_Load(object sender, EventArgs e)
        {
            LoadGridView();
            FillComboBox();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();

            string update = "UPDATE JetTable SET Made_Year = @Made_Year, Jet_Type = @Jet_Type, Power_source = @Power_source, " +  "Num_of_Seats = @Num_of_Seats, Weight = @Weight WHERE Jet_id = @Jet_id";

            using (SqlCommand cmd = new SqlCommand(update, con))
            {
                cmd.Parameters.AddWithValue("@Made_Year", Made_Year);
                cmd.Parameters.AddWithValue("@Jet_Type", Jet_Type);
                cmd.Parameters.AddWithValue("@Power_source", Power_source);
                cmd.Parameters.AddWithValue("@Num_of_Seats", Num_of_Seats);
                cmd.Parameters.AddWithValue("@Weight", Weight);
                cmd.Parameters.AddWithValue("@Jet_id", Jet_id);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Jet Details Updated Successfully!");
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
            string delete = "DELETE FROM JetTable WHERE Jet_id = @Jet_id";

            using (SqlCommand cmd = new SqlCommand(delete, con))
            {
                cmd.Parameters.AddWithValue("@Jet_id", txt_JetId.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                // Refresh the data grid view
                LoadGridView();
            }
        }

        private void cmb_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM JetTable WHERE Jet_id ='" + cmb_Search.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_JetId.Text = dr["Jet_id"].ToString();
                txt_MadeYear.Text = dr["Made_Year"].ToString();
                cmb_JetType.Text = dr["Jet_Type"].ToString();
                cmb_PowerSource.Text = dr["Power_source"].ToString();
                txt_NumOfPassnSeats.Text = dr["Num_of_Seats"].ToString();
                txt_Weight.Text = dr["Weight"].ToString();
            }
            con.Close( );
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_JetId.Text = "";
            txt_MadeYear.Text = "";
            cmb_JetType.SelectedItem = default;
            cmb_PowerSource.SelectedItem = default;
            txt_NumOfPassnSeats.Text = "";
            txt_Weight.Text = "";
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            LoadData();

            string save = "INSERT INTO JetTable (Jet_id, Made_Year, Jet_Type, Power_source, Num_of_Seats, Weight) " + "VALUES (@Jet_id, @Made_Year, @Jet_Type, @Power_source, @Num_of_Seats, @Weight)";

            using (SqlCommand cmd = new SqlCommand(save, con))
            {
                cmd.Parameters.AddWithValue("@Jet_id", Jet_id);
                cmd.Parameters.AddWithValue("@Made_Year", Made_Year);
                cmd.Parameters.AddWithValue("@Jet_Type", Jet_Type);
                cmd.Parameters.AddWithValue("@Power_source", Power_source);
                cmd.Parameters.AddWithValue("@Num_of_Seats", Num_of_Seats);
                cmd.Parameters.AddWithValue("@Weight", Weight);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Jet Details Registered successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                // Refresh the grid view to reflect the new data
                LoadGridView();
            }
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
