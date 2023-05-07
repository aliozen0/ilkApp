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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sepetData = new DataGridView();
            label1 = new Label();
            lbl_ucret = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)sepetData).BeginInit();
            SuspendLayout();
            // 
            // sepetData
            // 
            sepetData.AllowUserToAddRows = false;
            sepetData.AllowUserToDeleteRows = false;
            sepetData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sepetData.BackgroundColor = SystemColors.Control;
            sepetData.BorderStyle = BorderStyle.None;
            sepetData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sepetData.GridColor = SystemColors.Control;
            sepetData.Location = new Point(274, 128);
            sepetData.Name = "sepetData";
            sepetData.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            sepetData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            sepetData.RowHeadersWidth = 51;
            sepetData.RowTemplate.Height = 50;
            sepetData.Size = new Size(431, 343);
            sepetData.TabIndex = 0;
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
            // lbl_ucret
            // 
            lbl_ucret.AutoSize = true;
            lbl_ucret.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ucret.Location = new Point(549, 503);
            lbl_ucret.Name = "lbl_ucret";
            lbl_ucret.Size = new Size(0, 25);
            lbl_ucret.TabIndex = 2;
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
            Controls.Add(lbl_ucret);
            Controls.Add(label1);
            Controls.Add(sepetData);
            Name = "sepet";
            Size = new Size(957, 595);
            Load += sepet_Load;
            ((System.ComponentModel.ISupportInitialize)sepetData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView sepetData;
        private Label label1;
        private Label lbl_ucret;
        private Label label3;
        private Button button1;
    }
}
