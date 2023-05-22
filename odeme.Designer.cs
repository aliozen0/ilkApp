namespace ilkApp
{
    partial class odeme
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            radioPos = new RadioButton();
            radioNakit = new RadioButton();
            btnSiparisVer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 74);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "AD SOYAD";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 144);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 0;
            label2.Text = "TELEFON NO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 215);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 0;
            label3.Text = "ADRES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 294);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 0;
            label4.Text = "ÖDEME YÖNTEMİ";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(327, 71);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(251, 34);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(327, 141);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(251, 34);
            txtTelefon.TabIndex = 1;
            txtTelefon.TextChanged += textBox2_TextChanged;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(327, 215);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(251, 34);
            txtAdres.TabIndex = 1;
            txtAdres.TextChanged += textBox3_TextChanged;
            // 
            // radioPos
            // 
            radioPos.AutoSize = true;
            radioPos.Location = new Point(340, 294);
            radioPos.Name = "radioPos";
            radioPos.Size = new Size(209, 32);
            radioPos.TabIndex = 2;
            radioPos.TabStop = true;
            radioPos.Text = "POS CİHAZI (KART)";
            radioPos.UseVisualStyleBackColor = true;
            // 
            // radioNakit
            // 
            radioNakit.AutoSize = true;
            radioNakit.Location = new Point(340, 343);
            radioNakit.Name = "radioNakit";
            radioNakit.Size = new Size(90, 32);
            radioNakit.TabIndex = 2;
            radioNakit.TabStop = true;
            radioNakit.Text = "NAKİT";
            radioNakit.UseVisualStyleBackColor = true;
            // 
            // btnSiparisVer
            // 
            btnSiparisVer.Location = new Point(485, 426);
            btnSiparisVer.Name = "btnSiparisVer";
            btnSiparisVer.Size = new Size(185, 64);
            btnSiparisVer.TabIndex = 3;
            btnSiparisVer.Text = "SİPARİŞ VER";
            btnSiparisVer.UseVisualStyleBackColor = true;
            btnSiparisVer.Click += btnSiparisVer_Click;
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnSiparisVer);
            Controls.Add(radioNakit);
            Controls.Add(radioPos);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "odeme";
            Size = new Size(919, 580);
            Load += odeme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private RadioButton radioPos;
        private RadioButton radioNakit;
        private Button btnSiparisVer;
    }
}
