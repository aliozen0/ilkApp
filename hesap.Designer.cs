﻿namespace ilkApp
{
    partial class hesap
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
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 64);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "AYARLAR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 139);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 1;
            label2.Text = "E POSTA DEĞİŞTİR :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 228);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 1;
            label3.Text = "ŞİFRE DEĞİŞTİR :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 261);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 1;
            label4.Text = "Yeni Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 314);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 1;
            label5.Text = "Yeni Şifre Tekrar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(145, 485);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 1;
            label6.Text = "HESAPTAN CIKIŞ YAP";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(313, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(367, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(313, 311);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(367, 27);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(714, 123);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 4;
            button1.Text = "E Posta Değiştir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(576, 356);
            button2.Name = "button2";
            button2.Size = new Size(104, 36);
            button2.TabIndex = 4;
            button2.Text = "Şifre Değiştir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(350, 477);
            button3.Name = "button3";
            button3.Size = new Size(104, 36);
            button3.TabIndex = 4;
            button3.Text = "Çıkış Yap";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // hesap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "hesap";
            Size = new Size(899, 585);
            Load += hesap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
