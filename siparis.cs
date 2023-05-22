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
using Timer = System.Windows.Forms.Timer;
namespace ilkApp
{
    public partial class siparis : UserControl
    {
        private SqlConnection connection = null;
        private Timer timer;

        public siparis()
        {
            InitializeComponent();

            // Timer'ı oluştur ve yapılandır
            timer = new Timer();
            timer.Interval = 1000; // 5 saniye (örneğin)
            timer.Tick += Timer_Tick;
        }

        private void siparis_Load(object sender, EventArgs e)
        {
            Form1 form = this.FindForm() as Form1;
            int kullaniciID = Convert.ToInt32(form.KullaniciID);

            try
            {
                connection = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
                connection.Open();

                string query = "SELECT tarih, yemekAdi, ucret, odemeyontemi, durum, adres FROM siparisler WHERE kullaniciID = @kullaniciID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                // Timer'ı başlat
                timer.Start();
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Timer tetiklendiğinde DataGridView'i güncelle
            dataGridView1.Refresh();
        }
    }
}
