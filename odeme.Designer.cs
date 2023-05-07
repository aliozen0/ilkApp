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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(327, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(327, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 34);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(327, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 34);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(340, 294);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(209, 32);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "POS CİHAZI (KART)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(340, 343);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 32);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "NAKİT";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(485, 426);
            button1.Name = "button1";
            button1.Size = new Size(185, 64);
            button1.TabIndex = 3;
            button1.Text = "SİPARİŞ VER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "odeme";
            Size = new Size(919, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
    }
}
