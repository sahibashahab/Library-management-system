using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_mangement_system
{
    public partial class Logincs : Form
    {
        public Logincs()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-ELJNF61\\SQLEXPRESS;Initial Catalog=libraryy;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from stdsignup where std_id = '" + textBox1.Text + "' and stdPass ='" + textBox2.Text + "'", con1);
                con1.Open();
                InfoUser st1 = new InfoUser();
                DataTable dt = new DataTable();
                adapter.Fill(st1.dt2);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Sucessfully Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con1.Close();
            }
        }

        private void Logincs_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
