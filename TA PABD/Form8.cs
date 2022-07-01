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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }


        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbJudul.Text == "" || tbId.Text == "" || tbAuthor.Text == "" || tbPenerbit.Text == "" || tbTahun.Text == "" || tbCetakan.Text == "")
                MessageBox.Show("Please fill it completely !!");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection("Data Source = MYLEGION\\RAFI; Initial Catalog = PABD_TA; User Id=sa; Password=D3c4d3rs "))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddBuku", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@judul", tbJudul.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@id_buku", tbId.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@author", tbAuthor.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@penerbit", tbPenerbit.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tahun_terbit", tbTahun.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@cetakan", tbTahun.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    Form6 f6 = new Form6();
                    f6.Show();
                    this.Hide();
                }
            }
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void toolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
