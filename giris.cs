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

namespace ilkApp
{
    public partial class giris : Form
    {
        private SqlConnection baglanti = null;
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mail = txtEmail.Text;
            string sifre = txtSifre.Text;

            string kullaniciID = KullaniciDogrula(mail, sifre);
            if (!string.IsNullOrEmpty(kullaniciID))
            {
                Form1 anaForm = new Form1(kullaniciID);
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
            }
        }

        private string KullaniciDogrula(string mail, string sifre)
        {
            string kullaniciID = "";
                try
                {
                    baglanti.Open();
                    SqlCommand sqlKomut = new SqlCommand("SELECT KullaniciID FROM Kullanicilar WHERE mail = @mail AND sifre = @sifre", baglanti);
                    sqlKomut.Parameters.AddWithValue("@mail", mail);
                    sqlKomut.Parameters.AddWithValue("@sifre", sifre);

                    SqlDataReader sqlDR = sqlKomut.ExecuteReader();

                
                    if (sqlDR.Read())
                    {
                        kullaniciID = sqlDR["KullaniciID"].ToString();
                    }
                        
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı doğrulama işleminde bir hata oluştu: " + ex.Message);
                }
            

            return kullaniciID;
        }

       
    }
}
