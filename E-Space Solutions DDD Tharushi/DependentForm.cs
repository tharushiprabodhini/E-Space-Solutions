using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class DependentForm : Form
    {
        int Dependent_id, Colonist_id;
        string First_Name, Last_Name, Gender, Relationship_Of_Colonist;
        DateTime DOB;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

        public DependentForm()
        {
            InitializeComponent();
        }

        public void LoadData() // typing manually this line
        {
            Dependent_id = int.Parse(txt_depentId.Text);
            First_Name = txt_FirstName.Text;
            Last_Name = txt_LastName.Text;
            DOB = Dtp_DOB.Value.Date;
            if(rdb_Male.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            Relationship_Of_Colonist = txt_RelationshipOfColonist.Text;
            Colonist_id = int.Parse(cmb_ColonistId.SelectedItem.ToString());
        }

        private void FillComboBox()//typing manually this line
        {
            con.Open();
            string query = "SELECT Dependent_id FROM DependentTable";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmb_Search.Items.Add(read["Dependent_id"].ToString());
            }
            con.Close();
        }

        private void LoadGridView() // typing Manually this line
        {
            con.Open();
            string query = "SELECT * FROM DependentTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGV_Dependent.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }


        private void DependentForm_Load(object sender, EventArgs e)
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

        private void btn_Clear_Click(object sender, EventArgs e)//Clear code
        {
            txt_depentId.Text = "";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_RelationshipOfColonist.Text = "";
        }

        private void cmb_Search_SelectedIndexChanged(object sender, EventArgs e)//Search code
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM DependentTable WHERE Dependent_id ='" + cmb_Search.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_depentId.Text = dr["Dependent_id"].ToString();
                txt_FirstName.Text = dr["First_Name"].ToString();
                txt_LastName.Text = dr["Last_Name"].ToString();
                Dtp_DOB.Value = (DateTime)dr["DOB"];
                if (dr["Gender"].ToString() == "Male")
                {
                    rdb_Male.Checked = true;
                }
                else
                {
                    rdb_Female.Checked = true;
                }

                txt_RelationshipOfColonist.Text = dr["Relationship_Of_Colonist"].ToString();
                //cmb_ColonistId.Text = dr["Colonist_id"].ToString();
            }
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e) //Update code
        {
            LoadData();
            string update = "UPDATE DependentTable SET First_Name = @First_Name, Last_Name = @Last_Name, DOB = @DOB, " +
                         "Gender = @Gender, Relationship_Of_Colonist = @Relationship_Of_Colonist, Colonist_id = @Colonist_id " +
                         "WHERE Dependent_id = @Dependent_id";

            using (SqlCommand cmd = new SqlCommand(update, con))
            {
                cmd.Parameters.AddWithValue("@First_Name", First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Relationship_Of_Colonist", Relationship_Of_Colonist);
                cmd.Parameters.AddWithValue("@Colonist_id", Colonist_id);
                cmd.Parameters.AddWithValue("@Dependent_id", Dependent_id);

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

        private void btn_delete_Click(object sender, EventArgs e)//Delete code
        {
            con.Open();
            Dependent_id = int.Parse(txt_depentId.Text);
            string delete = "DELETE FROM DependentTable WHERE Dependent_id = '" + Dependent_id + "'";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadGridView();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)//Insert Code
        {
            LoadData();
            string Register = "INSERT INTO DependentTable (Dependent_id, First_Name, Last_Name, DOB, Gender, Relationship_Of_Colonist, Colonist_id) " +
                           "VALUES (@Dependent_id, @First_Name, @Last_Name, @DOB, @Gender, @Relationship_Of_Colonist, @Colonist_id)";

            using (SqlCommand cmd = new SqlCommand(Register, con))
            {
                cmd.Parameters.AddWithValue("@Dependent_id", Dependent_id);
                cmd.Parameters.AddWithValue("@First_Name", First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Relationship_Of_Colonist", Relationship_Of_Colonist);
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
