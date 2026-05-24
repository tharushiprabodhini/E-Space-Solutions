using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class ColonistLoginForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-171IFD8\SQLEXPRESS;Initial Catalog=E-Space_Tharushi;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;

        public ColonistLoginForm()
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

        private void btn_ClearUsername_Click(object sender, EventArgs e)
        {
            btn_ClearUsername.Text = "Enter the username";
        }

        private void btn_ClearPassword_Click(object sender, EventArgs e)
        {
            btn_ClearPassword.Text = "Enter the password";
        }

        private void chK_Password_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = chK_Password.Checked ? '\0' : '•';
        }


        private void txt_username_MouseClick(object sender, MouseEventArgs e)
        {
            txt_username.Text = "";
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "SELECT * FROM LoginTable WHERE Login_Username = @Username AND Login_Password = @Password AND Login_Account_Type = @AccountType";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", txt_username.Text);
            cmd.Parameters.AddWithValue("@Password", txt_password.Text);
            cmd.Parameters.AddWithValue("@AccountType", "Colonist"); // Login_Account_Type is set to "Colonist"

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ColonistViewDetailsForm colonistViewDetailsForm = new ColonistViewDetailsForm();
                this.Hide();
                colonistViewDetailsForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        


        private void ColonistLoginForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
