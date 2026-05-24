using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class PilotForm : Form
    {
        string Pilot_id, First_Name, Last_Name, Space_Hours, Gender, Earth_Address, Qualification, Email, Experience, Designation, Login_Account_Type, Login_Username, Login_Password;
        DateTime DOB;
        SqlConnection con = new SqlConnection (@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");


        public PilotForm()
        {
            InitializeComponent();
        }

        public void LoadData() // typing manually this line
        {
            Pilot_id = txt_PilotId.Text;
            First_Name = txt_FirstName.Text;
            Last_Name = txt_LastName.Text;
            Space_Hours = txt_SpaceHours.Text;
            DOB = Dtp_DOB.Value.Date;
            if (rdb_Male.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            Earth_Address = txt_EarthAddress.Text;
            Qualification = txt_Qualification.Text;
            Email = txt_Email.Text;
            Experience = txt_Experience.Text;
            Designation = cmb_Designation.Text;
            Login_Account_Type = cmb_AccType.Text;
            Login_Username = txt_LoginUsername.Text;
            Login_Password = txt_Password.Text;

        }


        private void FillComboBox()//typing manually this line
        {
            con.Open();
            string query = "SELECT Pilot_id FROM PilotTable";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmb_Search.Items.Add(read["Pilot_id"].ToString());
            }
            con.Close();
        }

        private void LoadGridView() // typing Manually this line
        {
            con.Open();
            string query = "SELECT * FROM PilotTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGV_Pilot.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_PilotId.Text = ""
;           txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_SpaceHours.Text = "";
            txt_EarthAddress.Text = "";
            txt_Qualification.Text = "";
            txt_Email.Text = "";
            txt_Experience.Text = "";
            cmb_Designation.SelectedItem = default;
            cmb_AccType.SelectedItem = default;
            txt_LoginUsername.Text = "";
            txt_Password.Text = "";
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
            try
            {
                con.Open();

                // Insert login details into LoginTable
                string saveLogin = "INSERT INTO LoginTable (Login_Username, Login_Password, Login_Account_Type) VALUES (@Login_Username, @Login_Password, @Login_Account_Type)";

                using (SqlCommand cmd = new SqlCommand(saveLogin, con))
                {
                    Login_Account_Type = cmb_AccType.Text;
                    Login_Username = txt_LoginUsername.Text;
                    Login_Password = txt_Password.Text;
                    cmd.Parameters.AddWithValue("@Login_Username", Login_Username);
                    cmd.Parameters.AddWithValue("@Login_Password", Login_Password);
                    cmd.Parameters.AddWithValue("@Login_Account_Type", Login_Account_Type);

                    cmd.ExecuteNonQuery();
                }

                // Insert Pilot details

                LoadData();
                string savePilot = "INSERT INTO PilotTable (Pilot_id, First_Name, Last_Name, Space_Hours, DOB, Gender, Earth_Address, Qualification, Email, Experience, Designation, Login_Account_Type, Login_Username, Login_Password) " + "VALUES (@Pilot_id, @First_Name, @Last_Name, @Space_Hours, @DOB, @Gender, @Earth_Address, @Qualification, @Email, @Experience, @Designation, @Login_Account_Type, @Login_Username, @Login_Password)";

                using (SqlCommand cmd01 = new SqlCommand(savePilot, con))
                {
                    cmd01.Parameters.AddWithValue("@Pilot_id", Pilot_id);
                    cmd01.Parameters.AddWithValue("@First_Name", First_Name);
                    cmd01.Parameters.AddWithValue("@Last_Name", Last_Name);
                    cmd01.Parameters.AddWithValue("@Space_Hours", Space_Hours);
                    cmd01.Parameters.AddWithValue("@DOB", DOB);
                    cmd01.Parameters.AddWithValue("@Gender", Gender);
                    cmd01.Parameters.AddWithValue("@Earth_Address", Earth_Address);
                    cmd01.Parameters.AddWithValue("@Qualification", Qualification);
                    cmd01.Parameters.AddWithValue("@Email", Email);
                    cmd01.Parameters.AddWithValue("@Experience", Experience);
                    cmd01.Parameters.AddWithValue("@Designation", Designation);
                    cmd01.Parameters.AddWithValue("@Login_Account_Type", Login_Account_Type);
                    cmd01.Parameters.AddWithValue("@Login_Username", Login_Username);
                    cmd01.Parameters.AddWithValue("@Login_Password", Login_Password);

                    cmd01.ExecuteNonQuery();
                }
                MessageBox.Show("Pilot details registered successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            // Refresh the DataGridView
            LoadGridView();
        }
          
        

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Update LoginTable
                string updateLogin = "UPDATE LoginTable SET Login_Password = @Login_Password, Login_Account_Type = @Login_Account_Type WHERE Login_Username = @Login_Username";

                using (SqlCommand cmd = new SqlCommand(updateLogin, con))
                {
                    cmd.Parameters.AddWithValue("@Login_Password", Login_Password);
                    cmd.Parameters.AddWithValue("@Login_Account_Type", Login_Account_Type);
                    cmd.Parameters.AddWithValue("@Login_Username", Login_Username);

                    cmd.ExecuteNonQuery();
                }

                // Update PilotTable

                LoadData();

                string updatePilot = "UPDATE PilotTable SET First_Name = @First_Name, Last_Name = @Last_Name, Space_Hours = @Space_Hours, DOB = @DOB, Gender = @Gender, Earth_Address = @Earth_Address, Qualification = @Qualification, Email = @Email, Experience = @Experience, Designation = @Designation, Login_Account_Type = @Login_Account_Type, Login_Username = @Login_Username, Login_Password = @Login_Password WHERE Pilot_id = @Pilot_id";

                using (SqlCommand cmd01 = new SqlCommand(updatePilot, con))
                {
                    cmd01.Parameters.AddWithValue("@First_Name", First_Name);
                    cmd01.Parameters.AddWithValue("@Last_Name", Last_Name);
                    cmd01.Parameters.AddWithValue("@Space_Hours", Space_Hours);
                    cmd01.Parameters.AddWithValue("@DOB", DOB);
                    cmd01.Parameters.AddWithValue("@Gender", Gender);
                    cmd01.Parameters.AddWithValue("@Earth_Address", Earth_Address);
                    cmd01.Parameters.AddWithValue("@Qualification", Qualification);
                    cmd01.Parameters.AddWithValue("@Email", Email);
                    cmd01.Parameters.AddWithValue("@Experience", Experience);
                    cmd01.Parameters.AddWithValue("@Designation", Designation);
                    cmd01.Parameters.AddWithValue("@Login_Account_Type", Login_Account_Type);
                    cmd01.Parameters.AddWithValue("@Login_Username", Login_Username);
                    cmd01.Parameters.AddWithValue("@Login_Password", Login_Password);
                    cmd01.Parameters.AddWithValue("@Pilot_id", Pilot_id);

                    cmd01.ExecuteNonQuery();
                }
                MessageBox.Show("Pilot  Details Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            // Refresh the grid view
            LoadGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Delete from LoginTable

                string deleteLogin = "DELETE FROM LoginTable WHERE Login_Username = @Login_Username";

                using (SqlCommand cmd = new SqlCommand(deleteLogin, con))
                {
                    Login_Username = txt_LoginUsername.Text;
                    cmd.Parameters.AddWithValue("@Login_Username", Login_Username);
                    cmd.ExecuteNonQuery();
                }


                // Delete from PilotTable
                Pilot_id = txt_PilotId.Text;

                string deletePilot = "DELETE FROM PilotTable WHERE Pilot_id = @Pilot_id";

                using (SqlCommand cmd01 = new SqlCommand(deletePilot, con))
                {
                    cmd01.Parameters.AddWithValue("@Pilot_id", Pilot_id);
                    cmd01.ExecuteNonQuery();
                }
                MessageBox.Show("Pilot details deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            // Refresh the grid view
            LoadGridView();
        }

        private void cmb_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PilotTable WHERE Pilot_id ='" + cmb_Search.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_PilotId.Text = dr["Pilot_id"].ToString();
                txt_FirstName.Text = dr["First_Name"].ToString();
                txt_LastName.Text = dr["Last_Name"].ToString();
                txt_SpaceHours.Text = dr["Space_Hours"].ToString();
                Dtp_DOB.Value = (DateTime)dr["DOB"];
                if (dr["Gender"].ToString() == "Male")
                {
                    rdb_Male.Checked = true;
                }
                else
                {
                    rdb_Female.Checked = true;
                }

                txt_EarthAddress.Text = dr["Earth_Address"].ToString();
                txt_Qualification.Text = dr["Qualification"].ToString();
                txt_Email.Text = dr["Email"].ToString();
                txt_Experience.Text = dr["Experience"].ToString();
                cmb_Designation.Text = dr["Designation"].ToString();
                cmb_AccType.Text = dr["Login_Account_Type"].ToString();
                txt_LoginUsername.Text = dr["Login_Username"].ToString();
                txt_Password.Text = dr["Login_Password"].ToString();
            }
            con.Close();
        }

        private void PilotForm_Load(object sender, EventArgs e)
        {
            LoadGridView();
            FillComboBox();
        }
    }
}
