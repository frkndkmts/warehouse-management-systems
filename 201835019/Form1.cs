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

namespace _201835019
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=FRKNDKMTS\SQLEXPRESS;Initial Catalog=db201835019;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string q = "SELECT * FROM ProductTypes";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
