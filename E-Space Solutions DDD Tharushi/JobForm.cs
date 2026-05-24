using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class JobForm : Form
    {
        string Job_id, Job_Title, Colonist_id;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");


        public JobForm()
        {
            InitializeComponent();
        }


        public void LoadData() // typing manually this line
        {
            Job_id = txt_JobId.Text;
            Job_Title = cmb_JobTitle.Text;
            Colonist_id = cmb_ColonistId.Text;
        }

        private void FillComboBox()//typing manually this line
        {
            con.Open();
            string query = "SELECT Job_id FROM JobTable";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmb_Search.Items.Add(read["Job_id"].ToString());
            }
            con.Close();
        }

        private void LoadGridView() // typing Manually this line
        {
            con.Open();
            string query = "SELECT * FROM JobTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGV_Job.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_JobId.Text = "";
            cmb_JobTitle.SelectedItem = default;
            cmb_ColonistId.SelectedItem = default;
        }

        private void JobForm_Load(object sender, EventArgs e)
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

        private void linkLabel_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure, want to Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            LoadData();
            string update = "UPDATE JobTable SET Job_Title = '" + Job_Title + "', Colonist_id = '" + Colonist_id + "' WHERE Job_id = '" + Job_id + "' ";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            Job_id = txt_JobId.Text;
            string delete = "DELETE FROM JobTable WHERE Job_id = '" + Job_id + "'";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadGridView();
        }

        private void cmb_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM JobTable WHERE Job_id ='" + cmb_Search.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_JobId.Text = dr["Job_id"].ToString();
                cmb_JobTitle.Text = dr["Job_Title"].ToString();
                cmb_ColonistId.Text = dr["Colonist_id"].ToString();
            }
            con.Close();
        }

        private void linkLabel_BackDshbrd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Hide();
            adminDashboard.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            con.Open();
            LoadData();
            string save = "INSERT INTO JobTable VALUES ('" + Job_id + "','" + Job_Title + "','" + Colonist_id + "') ";
            SqlCommand cmd = new SqlCommand(save, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registered Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadGridView();
        }
    }
}
