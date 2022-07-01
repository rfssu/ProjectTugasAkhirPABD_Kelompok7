using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TA_PABD
{
    public partial class Form1 : Form
    {
        string connectionstring = "Data Source = MYLEGION\\RAFI; Initial Catalog = PABD_TA; User Id=sa; Password=D3c4d3rs ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BReg_Click(object sender, EventArgs e)
        {
            if (tbidmbr.Text == "" || tbNama.Text == "" || tbAlamat.Text == "" || tbTlp.Text == "" || tbPass.Text == "")
                MessageBox.Show("Please fill it completely !!");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("MemberAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@id_member", tbidmbr.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@nm_member", tbNama.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@almt_member", tbAlamat.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tlp_member", tbTlp.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@passw", tbPass.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
