using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace ilkApp
{
    public partial class sepet : UserControl
    {
        private DataTable dataTable;
        private SqlConnection baglanti = null;
        private Timer timer;

        public sepet()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 5 saniye (değiştirebilirsiniz)
            timer.Tick += Timer_Tick;
        }

        private void sepet_Load(object sender, EventArgs e)
        {
            LoadData();
            timer.Start();
            sepetData.CellClick += sepetData_CellClick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                baglanti = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
                baglanti.Open();

                SqlCommand sqlKomut = new SqlCommand("SELECT * FROM sepetim2", baglanti);
                SqlDataReader sqlDR = sqlKomut.ExecuteReader();

                dataTable = new DataTable();
                dataTable.Load(sqlDR);

                sepetData.DataSource = dataTable;
                decimal toplamUcret = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    decimal ucret = Convert.ToDecimal(row["ucret"]);
                    toplamUcret += ucret;
                }

                lbl_ucret.Text = toplamUcret.ToString("C2"); // C2 formatı ile para birimi simgesi ve 2 basamak hassasiyeti

                sepetData.Columns["yemekID"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void sepetData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == sepetData.Columns["islem"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = sepetData.Rows[e.RowIndex];

                string yemekAdi = selectedRow.Cells["yemekAdi"].Value.ToString();
                string ucret = selectedRow.Cells["ucret"].Value.ToString();

                DialogResult result = MessageBox.Show(ucret + " TL değerindeki " + yemekAdi + " ürünü sepetten çıkarmak istiyor musunuz?", "Sepetten Çıkarma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = e.RowIndex;
                    string yemekID = sepetData.Rows[selectedRowIndex].Cells["yemekID"].Value.ToString();
                    DeleteRowFromDatabase(yemekID);
                    LoadData();
                }
            }
        }

        private void DeleteRowFromDatabase(string yemekID)
        {
            try
            {
                baglanti = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
                baglanti.Open();

                SqlCommand sqlKomut = new SqlCommand("DELETE FROM sepetim2 WHERE yemekID = @yemekID", baglanti);
                sqlKomut.Parameters.AddWithValue("@yemekID", yemekID);
                sqlKomut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }


    }
}