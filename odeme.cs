using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ilkApp
{
    public partial class odeme : UserControl
    {
        private SqlConnection connection = null;

        public odeme()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void odeme_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            SiparisVer();
        }

        private void SiparisVer()
        {
            // Kullanıcı bilgilerini al
            string adSoyad = txtAdSoyad.Text;
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;
            string odemeYontemi = "";

            if (radioNakit.Checked)
            {
                odemeYontemi = "Nakit";
            }
            else if (radioPos.Checked)
            {
                odemeYontemi = "Pos";
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçin.");
                return;
            }

            try
            {
                connection = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
                connection.Open();

                SqlCommand sepetCommand = new SqlCommand("SELECT * FROM sepetim2", connection);
                SqlDataReader sepetReader = sepetCommand.ExecuteReader();

                Form1 form = this.FindForm() as Form1;
                int kullaniciID = Convert.ToInt32(form.KullaniciID);
                DateTime tarih = DateTime.Now;
                string durum = "Hazırlanıyor";
                List<int> yemekIDListesi = new List<int>();
                List<string> yemekAdiListesi = new List<string>();
                decimal toplamUcret = 0;

                while (sepetReader.Read())
                {
                    int yemekID = Convert.ToInt32(sepetReader["yemekID"]);
                    string yemekAdi = sepetReader["yemekAdi"].ToString();
                    decimal ucret = Convert.ToDecimal(sepetReader["ucret"]);

                    yemekIDListesi.Add(yemekID);
                    yemekAdiListesi.Add(yemekAdi);
                    toplamUcret += ucret;
                }

                sepetReader.Close();

                if (yemekIDListesi.Count > 0)
                {
                    string yemekIDConcatenated = string.Join(",", yemekIDListesi);
                    string yemekAdiConcatenated = string.Join(",", yemekAdiListesi);

                    string query = "INSERT INTO siparisler (kullaniciID, yemekID, yemekAdi, ucret, durum, odemeyontemi, adsoyad, adres, telefon, tarih) " +
                                    "VALUES (@kullaniciID, @yemekID, @yemekAdi, @ucret, @durum, @odemeyontemi, @adsoyad, @adres, @telefon, @tarih)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                    command.Parameters.AddWithValue("@yemekID", yemekIDConcatenated);
                    command.Parameters.AddWithValue("@yemekAdi", yemekAdiConcatenated);
                    command.Parameters.AddWithValue("@ucret", toplamUcret);
                    command.Parameters.AddWithValue("@durum", durum);
                    command.Parameters.AddWithValue("@odemeyontemi", odemeYontemi);
                    command.Parameters.AddWithValue("@adsoyad", adSoyad);
                    command.Parameters.AddWithValue("@adres", adres);
                    command.Parameters.AddWithValue("@telefon", telefon);
                    command.Parameters.AddWithValue("@tarih", tarih.ToString("yyyy-MM-dd HH:mm:ss"));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Siparişiniz başarıyla verildi.");

                    SqlCommand sepetTemizleCommand = new SqlCommand("DELETE FROM sepetim2", connection);
                    sepetTemizleCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }




    }
}
