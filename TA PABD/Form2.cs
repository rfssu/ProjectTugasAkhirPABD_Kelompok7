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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BLog1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = MYLEGION\\RAFI; Initial Catalog = PABD_TA; User Id=sa; Password=D3c4d3rs"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM member WHERE id_member='" + IdMember.Text.Trim() + "' AND passw='" + Password.Text.Trim() + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid username or password");
        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void peminjamanBukuToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
