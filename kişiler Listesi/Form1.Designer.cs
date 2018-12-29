namespace kişiler_Listesi
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridkisi = new System.Windows.Forms.DataGridView();
            this.EkranaBas = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            this.Kaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.maskedTextTel = new System.Windows.Forms.MaskedTextBox();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridkisi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridkisi
            // 
            this.dataGridkisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridkisi.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridkisi.Location = new System.Drawing.Point(316, 12);
            this.dataGridkisi.Name = "dataGridkisi";
            this.dataGridkisi.Size = new System.Drawing.Size(665, 356);
            this.dataGridkisi.TabIndex = 9;
            // 
            // EkranaBas
            // 
            this.EkranaBas.Location = new System.Drawing.Point(316, 375);
            this.EkranaBas.Name = "EkranaBas";
            this.EkranaBas.Size = new System.Drawing.Size(665, 41);
            this.EkranaBas.TabIndex = 8;
            this.EkranaBas.Text = "Ekrana Getir";
            this.EkranaBas.UseVisualStyleBackColor = true;
            this.EkranaBas.Click += new System.EventHandler(this.EkranaBas_Click);
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(178, 362);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(99, 41);
            this.Temizle.TabIndex = 7;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(68, 362);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(104, 41);
            this.Kaydet.TabIndex = 6;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.Kaydet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textCity);
            this.groupBox1.Controls.Add(this.maskedTextTel);
            this.groupBox1.Controls.Add(this.textAdress);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textSurname);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 419);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Ekleme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "City :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adress :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name :";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(68, 186);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(209, 20);
            this.textCity.TabIndex = 4;
            // 
            // maskedTextTel
            // 
            this.maskedTextTel.Location = new System.Drawing.Point(68, 113);
            this.maskedTextTel.Mask = "(999) 000-0000";
            this.maskedTextTel.Name = "maskedTextTel";
            this.maskedTextTel.Size = new System.Drawing.Size(104, 20);
            this.maskedTextTel.TabIndex = 2;
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(68, 230);
            this.textAdress.Multiline = true;
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(209, 125);
            this.textAdress.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(68, 151);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(209, 20);
            this.textEmail.TabIndex = 3;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(68, 75);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(209, 20);
            this.textSurname.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(68, 39);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(209, 20);
            this.textName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EkranaBas);
            this.Controls.Add(this.dataGridkisi);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "Kisi Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridkisi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridkisi;
        private System.Windows.Forms.Button EkranaBas;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.MaskedTextBox maskedTextTel;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
    }
}

