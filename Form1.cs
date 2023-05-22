using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ilkApp
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        private SqlConnection baglanti = null;
        private SqlConnection connection = null;
        private string kullaniciID;

        public string KullaniciID { get => kullaniciID; set => kullaniciID = value; }

        public Form1(string kullaniciID)
        {

            InitializeComponent();
            this.kullaniciID = kullaniciID;
            odeme1.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
            yemeklerData.CellClick += yemeklerData_CellClick;
            connection = new SqlConnection(@"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True");
            connection.Open();
            lbl_deneme.Text = kullaniciID.ToString();
            LoadData();
        }

        private void LoadData()
        {
            try
            {

                baglanti.Open();

                SqlCommand sqlKomut = new SqlCommand("SELECT yemekID,kategoriAdi,yemekAdi,ucret,aciklama FROM yemekler", baglanti);
                SqlDataReader sqlDR = sqlKomut.ExecuteReader();

                dataTable = new DataTable();
                dataTable.Load(sqlDR);

                yemeklerData.DataSource = dataTable;
                yemeklerData.Columns["yemekID"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluþtu" + ex.ToString());

            }

            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            anasayfa1.Hide();
            hesap1.Hide();
            siparis1.Show();
            sepet1.Hide();
            odeme1.Hide();
            button9.Hide();
            yemeklerData.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            anasayfa1.Hide();
            hesap1.Show();
            siparis1.Hide();
            sepet1.Hide();
            odeme1.Hide();
            button9.Hide();
            yemeklerData.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yemeklerData.Show();
            anasayfa1.Hide();
            hesap1.Hide();
            siparis1.Hide();
            sepet1.Hide();
            odeme1.Hide();
            button9.Hide();
            DataView dataView = new DataView(dataTable);
            dataView.RowFilter = "kategoriAdi = 'burger'";
            yemeklerData.DataSource = dataView;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            anasayfa1.Show();
            hesap1.Hide();
            siparis1.Hide();
            sepet1.Hide();
            odeme1.Hide();
            button9.Hide();
            yemeklerData.Hide();

        }

        private void siparis1_Load(object sender, EventArgs e)
        {

        }

        private void sepet1_Load(object sender, EventArgs e)
        {


        }

        private void button11_Click(object sender, EventArgs e)
        {
            sepet1.Show();
            siparis1.Hide();
            hesap1.Hide();
            anasayfa1.Hide();
            odeme1.Hide();
            button9.Show();
            yemeklerData.Hide();
            button9.Visible = true;
        }

        private void odeme1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            odeme1.Show();
            sepet1.Hide();
            siparis1.Hide();
            hesap1.Hide();
            anasayfa1.Hide();
            yemeklerData.Hide();
            button9.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            yemeklerData.Show();
            anasayfa1.Hide();
            hesap1.Hide();
            siparis1.Hide();
            sepet1.Hide();
            odeme1.Hide();
            button9.Hide();


            DataView dataView = new DataView(dataTable);
            dataView.RowFilter = "kategoriAdi = 'pizza'";
            yemeklerData.DataSource = dataView;
        }

        private void yemeklerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void yemeklerData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == yemeklerData.Columns["aciklama"].Index && e.RowIndex >= 0) // Geçerli bir satýr týklandýðýný doðrulayýn
            {
                DataGridViewRow selectedRow = yemeklerData.Rows[e.RowIndex];
                int yemekID = Convert.ToInt32(selectedRow.Cells["yemekID"].Value);
                string yemekAdi = selectedRow.Cells["yemekAdi"].Value.ToString();
                decimal ucret = Convert.ToDecimal(selectedRow.Cells["ucret"].Value);
                string islem = "SEPETTEN ÇIKAR";
                string query = "INSERT INTO sepetim2 (yemekID , yemekAdi, ucret,islem) VALUES (@yemekID, @yemekAdi, @ucret,@islem)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@yemekID", yemekID);
                command.Parameters.AddWithValue("@yemekAdi", yemekAdi);
                command.Parameters.AddWithValue("@ucret", ucret);
                command.Parameters.AddWithValue("@islem", islem);
                command.ExecuteNonQuery();

                label1.Text = yemekAdi + " sepete eklendi";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
           
            
        }
    }
}