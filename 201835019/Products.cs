using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201835019
{
    public partial class Products : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=FRKNDKMTS\SQLEXPRESS;Initial Catalog=db201835019;Integrated Security=True");
        public Products()
        {
            InitializeComponent();
        }

        Form1 formForm1;
        private void ProductADD_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();


                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Products (Brand, Model, ModelType, SerialNumber, Stock, ProductTypeCode) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                sqlCommand.Parameters.AddWithValue("@p1", txtbrand.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtmodel.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtmodeltype.Text);
                sqlCommand.Parameters.AddWithValue("@p4", txtsn.Text);
                sqlCommand.Parameters.AddWithValue("@p5", "true");
                sqlCommand.Parameters.AddWithValue("@p6", txtproducttypecode.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while adding product" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            showdata();
        }
        private void showdata()
        {
            try
            {
                string q = "SELECT * FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgw1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Products_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void dgw1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            delayfee.Text = "0";
            int selectedClm = dgw1.SelectedCells[0].RowIndex;
            label2.Text = dgw1.Rows[selectedClm].Cells[0].Value.ToString();
            txtbrand.Text = dgw1.Rows[selectedClm].Cells[1].Value.ToString();
            txtmodel.Text = dgw1.Rows[selectedClm].Cells[2].Value.ToString();
            txtmodeltype.Text = dgw1.Rows[selectedClm].Cells[3].Value.ToString();
            txtsn.Text = dgw1.Rows[selectedClm].Cells[4].Value.ToString();
            txtproducttypecode.Text = dgw1.Rows[selectedClm].Cells[8].Value.ToString();

            txtstore.Text = dgw1.Rows[selectedClm].Cells[6].Value.ToString();
            if (dgw1.Rows[selectedClm].Cells[7].Value != DBNull.Value)

                dateTimePicker1.Value = (DateTime)dgw1.Rows[selectedClm].Cells[7].Value;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Products SET Brand=@P1,  Model=@P2 ,  ModelType=@P3, SerialNumber=@P4 , ProductTypeCode=@P5 WHERE ID=@P6", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", txtbrand.Text);
                sqlCommand.Parameters.AddWithValue("@P2", txtmodel.Text);
                sqlCommand.Parameters.AddWithValue("@P3", txtmodeltype.Text);
                sqlCommand.Parameters.AddWithValue("@P4", txtsn.Text);
                sqlCommand.Parameters.AddWithValue("@P5", txtproducttypecode.Text);
                sqlCommand.Parameters.AddWithValue("@P6", label2.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while updating product" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            showdata();
        }

        private void btndispatch_Click(object sender, EventArgs e)
        {
            if (label2.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Products SET ArrivalStore=@P1,  DeliveryDate=@P2, Stock=@P3 WHERE ID=@P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", txtstore.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", label2.Text);
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while updating product" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                showdata();
            }
            else
            {
                MessageBox.Show("Please choose a product  !!!");
            }
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (label2.Text != "-")
            {
                DateTime today = DateTime.Now;
                int gunfarki = (int)(today - dateTimePicker1.Value.Date).TotalDays;
                if (gunfarki > 5)
                {
                    int refund = (gunfarki - 5) * 750;
                    delayfee.Text = refund.ToString();

                }

            }

        }

        private void btnrefund_Click(object sender, EventArgs e)
        {
            if (label2.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Products SET ArrivalStore=@P1,  DeliveryDate=@P2, Stock=@P3 WHERE ID=@P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", txtstore.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", "True");
                    sqlCommand.Parameters.AddWithValue("@P4", label2.Text);
                    sqlCommand.ExecuteNonQuery();
                    txtstore.Text = " ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while updating product" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                showdata();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartext2();
        }
        public void cleartext2()
        {
            label2.Text = "-";
            txtbrand.Text = "";
            txtmodel.Text = "";
            txtmodeltype.Text = "";
            txtsn.Text = "";
            txtproducttypecode.Text = "";
            txtstore.Text = "";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            searchdatashow();
        }
        private void searchdatashow()
        {
            try
            {
                string q = "SELECT * FROM Products WHERE Brand LIKE  '"+txtbrand.Text+ "%'       AND Model    LIKE '" + txtmodel.Text + "%' AND ModelType    LIKE '" + txtmodeltype.Text + "%' AND SerialNumber    LIKE '" + txtsn.Text + "%' AND ProductTypeCode    LIKE '" + txtproducttypecode.Text + "%' AND ArrivalStore    LIKE '" + txtstore.Text + "%' ";
                
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgw1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnshow1_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if(label2.Text =="-" || label2.Text == "")
            {
                MessageBox.Show("Please choose a product to delete from this list !");
            }
            else { 
                
                try
                {
                    baglanti.Open(); //DELETE FROM Products WHERE ID = 3

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Products WHERE ID =@P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", label2.Text);
                
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while deleting product !" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                showdata();
                cleartext2();
            }
        }

        private void Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formForm1 = new Form1();

            formForm1.Show();
        }
    }
    }

