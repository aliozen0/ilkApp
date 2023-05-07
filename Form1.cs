namespace ilkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            odeme1.Hide();
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
        }

        private void button5_Click(object sender, EventArgs e)
        {

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
        }
    }
}