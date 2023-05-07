namespace ilkApp
{
    partial class sepet
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
            dataGridView1 = new DataGridView();
            ÜRÜN = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ÜRÜN, Column1, Column2 });
            dataGridView1.Location = new Point(274, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(431, 343);
            dataGridView1.TabIndex = 0;
            // 
            // ÜRÜN
            // 
            ÜRÜN.HeaderText = "ÜRÜN";
            ÜRÜN.MinimumWidth = 6;
            ÜRÜN.Name = "ÜRÜN";
            ÜRÜN.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "FİYAT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "ADET";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(283, 503);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 1;
            label1.Text = "TOPLAM TUTAR :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 510);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 2;
            label2.Text = "ALLAH NE VERDİYSE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(274, 54);
            label3.Name = "label3";
            label3.Size = new Size(164, 36);
            label3.TabIndex = 3;
            label3.Text = "SEPETİM";
            // 
            // button1
            // 
            button1.Location = new Point(761, 152);
            button1.Name = "button1";
            button1.Size = new Size(104, 54);
            button1.TabIndex = 4;
            button1.Text = "Sepetten Çıkar";
            button1.UseVisualStyleBackColor = true;
            // 
            // sepet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "sepet";
            Size = new Size(957, 595);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ÜRÜN;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
