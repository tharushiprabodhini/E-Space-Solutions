using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Space_Solutions_DDD_Tharushi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (ProgressBar_Loading.Value < 100)
            {
                ProgressBar_Loading.Value += 1;
                lbl_count.Text = ProgressBar_Loading.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                SelectLoginTypeForm selectLoginTypeForm = new SelectLoginTypeForm();
                this.Hide();
                selectLoginTypeForm.Show();
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_count_Click(object sender, EventArgs e)
        {

        }
    }
}
