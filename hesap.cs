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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ilkApp
{
    public partial class hesap : UserControl
    {
        private SqlConnection connection = null;
        public hesap()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hesap_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            giris girisFormu = new giris();
            girisFormu.Show();

            this.FindForm().Close();



        }

        private void buttonEpostaDegistir_Click(object sender, EventArgs e)
        {

        }

        private void buttonSifreDegistir_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEpostaDegistir_Click_1(object sender, EventArgs e)
        {
            string yeniEposta = textBoxYeniEposta.Text;

            // E-posta değiştirme işlemleri
            try
            {
                // Veritabanına bağlantıyı aç
                string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı ID'yi al
                    Form1 form = this.FindForm() as Form1;
                    int kullaniciID = Convert.ToInt32(form.KullaniciID);

                    // E-postayı güncelle
                    string query = "UPDATE kullanicilar SET mail = @yeniEposta WHERE kullaniciID = @kullaniciID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@yeniEposta", yeniEposta);
                        command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("E-posta başarıyla değiştirildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yeniSifre = textBoxYeniSifre.Text;
            string yeniSifreTekrar = textBoxYeniSifreTekrar.Text;

            // Şifre değiştirme işlemleri
            try
            {
                if (yeniSifre != yeniSifreTekrar)
                {
                    MessageBox.Show("Yeni şifreler eşleşmiyor.");
                    return;
                }

                // Veritabanına bağlantıyı aç
                string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı ID'yi al
                    Form1 form = this.FindForm() as Form1;
                    int kullaniciID = Convert.ToInt32(form.KullaniciID);

                    // Şifreyi güncelle
                    string query = "UPDATE kullanicilar SET sifre = @yeniSifre WHERE kullaniciID = @kullaniciID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                        command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Şifre başarıyla değiştirildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }

        }
    }
}

