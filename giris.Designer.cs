﻿namespace ilkApp
{
    partial class giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 205);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "E posta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 313);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(555, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 32);
            txtEmail.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(555, 306);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(286, 32);
            txtSifre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(681, 418);
            button1.Name = "button1";
            button1.Size = new Size(160, 51);
            button1.TabIndex = 2;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 589);
            Controls.Add(button1);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "giris";
            Text = "giris";
            Load += giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Button button1;
    }
}