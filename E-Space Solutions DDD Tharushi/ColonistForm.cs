using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class ColonistForm : Form
    {
        int Colonist_id;
        string First_Name, Last_Name, Middle_Name, Surname, Gender, Earth_Address, Qualification, Civil_Status, Cont_No01, Cont_No02, Email, CountOfFam, Login_Account_Type, Login_Username, Login_Password;

        private void dGV_colonist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DateTime DOB;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");


        private void cmb_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ColonistTable WHERE Colonist_id ='" + cmb_Search.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_colonistId.Text = dr["Colonist_id"].ToString();
                txt_FirstName.Text = dr["First_Name"].ToString();
                txt_MiddleName.Text = dr["Middle_Name"].ToString();
                txt_Surname.Text = dr["Surname"].ToString();
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
                cmb_CivilStatus.Text = dr["Civil_Status"].ToString();
                txt_ContNo01.Text = dr["Cont_No01"].ToString();
                txt_ContNo02.Text = dr["Cont_No02"].ToString();
                txt_Email.Text = dr["Email"].ToString();
                txt_CountOfFamMem.Text = dr["CountOfFam"].ToString();
                cmb_AccType.Text = dr["Login_Account_Type"].ToString();
                txt_LoginUN.Text = dr["Login_Username"].ToString();
                txt_LoginPW.Text = dr["Login_Password"].ToString();
            }
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Update into Login table
                string updateLogin = @"UPDATE LoginTable SET Login_Password = @Login_Password,  Login_Account_Type = @Login_Account_Type WHERE Login_Username = @Login_Username";

                using (SqlCommand cmd = new SqlCommand(updateLogin, con))
                {
                    Login_Account_Type = cmb_AccType.Text;
                    Login_Username = txt_LoginUN.Text;
                    Login_Password = txt_LoginPW.Text;
                    cmd.Parameters.AddWithValue("@Login_Password", Login_Password);
                    cmd.Parameters.AddWithValue("@Login_Account_Type", Login_Account_Type);
                    cmd.Parameters.AddWithValue("@Login_Username", Login_Username);
                    cmd.ExecuteNonQuery();
                }

                // Update into Colonist table
                LoadData();
                
                string updateColonist = @"UPDATE ColonistTable  SET First_Name = @First_Name, Middle_Name = @Middle_Name, Surname = @Surname,  DOB = @DOB,  Gender = @Gender,  Earth_Address = @Earth_Address,  Qualification = @Qualification,  Civil_Status = @Civil_Status,  Cont_No01 = @Cont_No01,  Cont_No02 = @Cont_No02,   Email = @Email,  CountOfFam = @CountOfFam,  Login_Account_Type = @Login_Account_Type, Login_Username = @Login_Username,  Login_Password = @Login_Password WHERE Colonist_id = @Colonist_id";

                using (SqlCommand cmd01 = new SqlCommand(updateColonist, con))
                {
                    cmd01.Parameters.AddWithValue("@First_Name", First_Name);
                    cmd01.Parameters.AddWithValue("@Middle_Name", Middle_Name);
                    cmd01.Parameters.AddWithValue("@Surname", Surname);
                    cmd01.Parameters.AddWithValue("@DOB", DOB);
                    cmd01.Parameters.AddWithValue("@Gender", Gender);
                    cmd01.Parameters.AddWithValue("@Earth_Address", Earth_Address);
                    cmd01.Parameters.AddWithValue("@Qualification", Qualification);
                    cmd01.Parameters.AddWithValue("@Civil_Status", Civil_Status);
                    cmd01.Parameters.AddWithValue("@Cont_No01", Cont_No01);
                    cmd01.Parameters.AddWithValue("@Cont_No02", Cont_No02);
                    cmd01.Parameters.AddWithValue("@Email", Email);
                    cmd01.Parameters.AddWithValue("@CountOfFam", CountOfFam);
                    cmd01.Parameters.AddWithValue("@Login_Account_Type", Login_Account_Type);
                    cmd01.Parameters.AddWithValue("@Login_Username", Login_Username);
                    cmd01.Parameters.AddWithValue("@Login_Password", Login_Password);
                    cmd01.Parameters.AddWithValue("@Colonist_id", Colonist_id);
                    cmd01.ExecuteNonQuery();
                }
                MessageBox.Show("Colonist Details Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public ColonistForm()
        {
            InitializeComponent();
        }

        public void LoadData() // typing manually this line
        {
            Colonist_id = int.Parse(txt_colonistId.Text);
            First_Name = txt_FirstName.Text;
            Middle_Name = txt_MiddleName.Text;
            Surname = txt_Surname.Text;
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
            Civil_Status = cmb_CivilStatus.Text;
            Cont_No01 = txt_ContNo01.Text;
            Cont_No02 = txt_ContNo02.Text;
            CountOfFam = txt_CountOfFamMem.Text;
            Email = txt_Email.Text;
            CountOfFam = txt_CountOfFamMem.Text;
            Login_Account_Type = cmb_AccType.Text;
            Login_Username = txt_LoginUN.Text;
            Login_Password = txt_LoginPW.Text;
        }

        private void FillComboBox()//typing manually this line
        {
            con.Open();
            string query = "SELECT Colonist_id FROM ColonistTable";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmb_Search.Items.Add(read["Colonist_id"].ToString());
            }
            con.Close();
        }




        private void LoadGridView() // typing Manually this line
        {
            con.Open();
            string query = "SELECT * FROM ColonistTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGV_colonist.DataSource = ds.Tables[0].DefaultView;
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



        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_colonistId.Text = "";
            txt_FirstName.Text = "";
            txt_MiddleName.Text = "";
            txt_Surname.Text = "";
            txt_EarthAddress.Text = "";
            txt_Qualification.Text = "";
            txt_ContNo01.Text = "";
            txt_ContNo02.Text = "";
            txt_Email.Text = "";
            txt_CountOfFamMem.Text = "";
            txt_LoginUN.Text = "";
            txt_LoginPW.Text = "";
        }



        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Insert into LoginTable
                string RegisterLogin = @"INSERT INTO LoginTable (Login_Account_Type, Login_Username, Login_Password) VALUES (@Login_Account_Type, @Login_Username, @Login_Password)";
                
                using (SqlCommand cmd = new SqlCommand(RegisterLogin, con))
                {
                    Login_Account_Type = cmb_AccType.Text;
                    Login_Username = txt_LoginUN.Text;
                    Login_Password = txt_LoginPW.Text;
                    cmd.Parameters.AddWithValue("@Login_Account_Type", Login_Account_Type);
                    cmd.Parameters.AddWithValue("@Login_Username", Login_Username);
                    cmd.Parameters.AddWithValue("@Login_Password", Login_Password);
                    cmd.ExecuteNonQuery();
                }

                // Insert into Colonist table
                LoadData();

                string RegisterColonist = @"INSERT INTO ColonistTable (Colonist_id, First_Name, Middle_Name, Surname, DOB, Gender, Earth_Address, Qualification, Civil_Status, Cont_No01, Cont_No02, Email, CountOfFam, Login_Account_Type, Login_Username, Login_Password)  VALUES (@Colonist_id, @First_Name, @Middle_Name, @Surname, @DOB, @Gender, @Earth_Address, @Qualification, @Civil_Status, @Cont_No01, @Cont_No02, @Email, @CountOfFam, @Login_Account_Type, @Login_Username, @Login_Password)";
                
                using (SqlCommand cmd01 = new SqlCommand(RegisterColonist, con))
                {
                    cmd01.Parameters.AddWithValue("@Colonist_id", Colonist_id);
                    cmd01.Parameters.AddWithValue("@First_Name", First_Name);
                    cmd01.Parameters.AddWithValue("@Middle_Name", Middle_Name);
                    cmd01.Parameters.AddWithValue("@Surname", Surname);
                    cmd01.Parameters.AddWithValue("@DOB", DOB);
                    cmd01.Parameters.AddWithValue("@Gender", Gender);
                    cmd01.Parameters.AddWithValue("@Earth_Address", Earth_Address);
                    cmd01.Parameters.AddWithValue("@Qualification", Qualification);
                    cmd01.Parameters.AddWithValue("@Civil_Status", Civil_Status);
                    cmd01.Parameters.AddWithValue("@Cont_No01", Cont_No01);
                    cmd01.Parameters.AddWithValue("@Cont_No02", Cont_No02);
                    cmd01.Parameters.AddWithValue("@Email", Email);
                    cmd01.Parameters.AddWithValue("@CountOfFam", CountOfFam);
                    cmd01.Parameters.AddWithValue("@Login_Account_Type", Login_Account_Type);
                    cmd01.Parameters.AddWithValue("@Login_Username", Login_Username);
                    cmd01.Parameters.AddWithValue("@Login_Password", Login_Password);
                    cmd01.ExecuteNonQuery();
                }

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

            // Refresh the grid view
            LoadGridView();
        }



        private void ColonistForm_Load(object sender, EventArgs e)
        {
            LoadGridView();
            FillComboBox();
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string deleteLogin = "DELETE FROM LoginTable WHERE Login_Username = @Login_Username";

                using (SqlCommand cmd = new SqlCommand(deleteLogin, con))
                {
                    Login_Username = txt_LoginUN.Text;
                    cmd.Parameters.AddWithValue("@Login_Username", Login_Username);
                    cmd.ExecuteNonQuery();
                }

                string deleteColonist = "DELETE FROM ColonistTable WHERE Colonist_id = @Colonist_id";

                using (SqlCommand cmd = new SqlCommand(deleteColonist, con))
                {
                    Colonist_id = int.Parse(txt_colonistId.Text);
                    cmd.Parameters.AddWithValue("@Colonist_id", Colonist_id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            // Refresh the grid view to reflect changes
            LoadGridView();
        }
    }
}


