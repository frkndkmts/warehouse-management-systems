using System.Data.SqlClient;

namespace _201835019
{
    public partial class LoginScreen : Form
    {
        Products formProducts;
        public LoginScreen()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=FRKNDKMTS\SQLEXPRESS;Initial Catalog=db201835019;Integrated Security=True");
        

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "";
           try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Password FROM  Admins WHERE Username = @p1",baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxUsername.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    password = sqlDataReader[0].ToString(); 
                }
               // label4.Text = password; 
                if(password == textBoxPassword.Text)
                {
                    
                    formProducts = new Products();
                    this.Hide();
                    formProducts.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password invalid !");
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                }
            }
           catch(Exception ex)
            {
                MessageBox.Show(" ERROR!! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}