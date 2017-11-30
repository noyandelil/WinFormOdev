namespace WindowsFormsApp1
{
    partial class Form1
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
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.rtxtSoru = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdDogru = new System.Windows.Forms.RadioButton();
            this.rdYanlis = new System.Windows.Forms.RadioButton();
            this.lstAd = new System.Windows.Forms.ListBox();
            this.lstSoyad = new System.Windows.Forms.ListBox();
            this.lstDersler = new System.Windows.Forms.ListBox();
            this.lstSoru = new System.Windows.Forms.ListBox();
            this.lstCevap = new System.Windows.Forms.ListBox();
            this.lstDurum = new System.Windows.Forms.ListBox();
            this.BtnGoruntule = new System.Windows.Forms.Button();
            this.chkMatematik = new System.Windows.Forms.CheckBox();
            this.chkFizik = new System.Windows.Forms.CheckBox();
            this.chkKimya = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(77, 9);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(141, 20);
            this.TxtAd.TabIndex = 0;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(77, 55);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(141, 20);
            this.TxtSoyad.TabIndex = 1;
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Items.AddRange(new object[] {
            "Cografya",
            "Matematik",
            "Fizik",
            "Tarih"});
            this.cmbDers.Location = new System.Drawing.Point(77, 103);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(141, 21);
            this.cmbDers.TabIndex = 2;
            // 
            // rtxtSoru
            // 
            this.rtxtSoru.Location = new System.Drawing.Point(77, 151);
            this.rtxtSoru.Name = "rtxtSoru";
            this.rtxtSoru.Size = new System.Drawing.Size(141, 108);
            this.rtxtSoru.TabIndex = 3;
            this.rtxtSoru.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dersler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soru";
            // 
            // rdDogru
            // 
            this.rdDogru.AutoSize = true;
            this.rdDogru.Location = new System.Drawing.Point(236, 152);
            this.rdDogru.Name = "rdDogru";
            this.rdDogru.Size = new System.Drawing.Size(54, 17);
            this.rdDogru.TabIndex = 10;
            this.rdDogru.TabStop = true;
            this.rdDogru.Text = "Dogru";
            this.rdDogru.UseVisualStyleBackColor = true;
            this.rdDogru.CheckedChanged += new System.EventHandler(this.rdDogru_CheckedChanged);
            // 
            // rdYanlis
            // 
            this.rdYanlis.AutoSize = true;
            this.rdYanlis.Location = new System.Drawing.Point(236, 194);
            this.rdYanlis.Name = "rdYanlis";
            this.rdYanlis.Size = new System.Drawing.Size(53, 17);
            this.rdYanlis.TabIndex = 11;
            this.rdYanlis.TabStop = true;
            this.rdYanlis.Text = "Yanlis";
            this.rdYanlis.UseVisualStyleBackColor = true;
            this.rdYanlis.CheckedChanged += new System.EventHandler(this.rdYanlis_CheckedChanged);
            // 
            // lstAd
            // 
            this.lstAd.FormattingEnabled = true;
            this.lstAd.Location = new System.Drawing.Point(-1, 314);
            this.lstAd.Name = "lstAd";
            this.lstAd.Size = new System.Drawing.Size(120, 95);
            this.lstAd.TabIndex = 12;
            // 
            // lstSoyad
            // 
            this.lstSoyad.FormattingEnabled = true;
            this.lstSoyad.Location = new System.Drawing.Point(142, 314);
            this.lstSoyad.Name = "lstSoyad";
            this.lstSoyad.Size = new System.Drawing.Size(120, 95);
            this.lstSoyad.TabIndex = 13;
            // 
            // lstDersler
            // 
            this.lstDersler.FormattingEnabled = true;
            this.lstDersler.Location = new System.Drawing.Point(283, 314);
            this.lstDersler.Name = "lstDersler";
            this.lstDersler.Size = new System.Drawing.Size(120, 95);
            this.lstDersler.TabIndex = 14;
            // 
            // lstSoru
            // 
            this.lstSoru.FormattingEnabled = true;
            this.lstSoru.Location = new System.Drawing.Point(423, 314);
            this.lstSoru.Name = "lstSoru";
            this.lstSoru.Size = new System.Drawing.Size(120, 95);
            this.lstSoru.TabIndex = 15;
            // 
            // lstCevap
            // 
            this.lstCevap.FormattingEnabled = true;
            this.lstCevap.Location = new System.Drawing.Point(571, 314);
            this.lstCevap.Name = "lstCevap";
            this.lstCevap.Size = new System.Drawing.Size(120, 95);
            this.lstCevap.TabIndex = 16;
            // 
            // lstDurum
            // 
            this.lstDurum.FormattingEnabled = true;
            this.lstDurum.Location = new System.Drawing.Point(721, 314);
            this.lstDurum.Name = "lstDurum";
            this.lstDurum.Size = new System.Drawing.Size(120, 95);
            this.lstDurum.TabIndex = 17;
            // 
            // BtnGoruntule
            // 
            this.BtnGoruntule.Location = new System.Drawing.Point(603, 16);
            this.BtnGoruntule.Name = "BtnGoruntule";
            this.BtnGoruntule.Size = new System.Drawing.Size(106, 36);
            this.BtnGoruntule.TabIndex = 18;
            this.BtnGoruntule.Text = "Goruntule";
            this.BtnGoruntule.UseVisualStyleBackColor = true;
            this.BtnGoruntule.Click += new System.EventHandler(this.BtnGoruntule_Click);
            // 
            // chkMatematik
            // 
            this.chkMatematik.AutoSize = true;
            this.chkMatematik.Location = new System.Drawing.Point(409, 75);
            this.chkMatematik.Name = "chkMatematik";
            this.chkMatematik.Size = new System.Drawing.Size(75, 17);
            this.chkMatematik.TabIndex = 19;
            this.chkMatematik.Text = "Matematik";
            this.chkMatematik.UseVisualStyleBackColor = true;
            this.chkMatematik.CheckedChanged += new System.EventHandler(this.chkMatematik_CheckedChanged);
            // 
            // chkFizik
            // 
            this.chkFizik.AutoSize = true;
            this.chkFizik.Location = new System.Drawing.Point(409, 111);
            this.chkFizik.Name = "chkFizik";
            this.chkFizik.Size = new System.Drawing.Size(47, 17);
            this.chkFizik.TabIndex = 20;
            this.chkFizik.Text = "Fizik";
            this.chkFizik.UseVisualStyleBackColor = true;
            this.chkFizik.CheckedChanged += new System.EventHandler(this.chkFizik_CheckedChanged);
            // 
            // chkKimya
            // 
            this.chkKimya.AutoSize = true;
            this.chkKimya.Location = new System.Drawing.Point(409, 152);
            this.chkKimya.Name = "chkKimya";
            this.chkKimya.Size = new System.Drawing.Size(54, 17);
            this.chkKimya.TabIndex = 21;
            this.chkKimya.Text = "Kimya";
            this.chkKimya.UseVisualStyleBackColor = true;
            this.chkKimya.CheckedChanged += new System.EventHandler(this.chkKimya_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 408);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkKimya);
            this.Controls.Add(this.chkFizik);
            this.Controls.Add(this.chkMatematik);
            this.Controls.Add(this.BtnGoruntule);
            this.Controls.Add(this.lstDurum);
            this.Controls.Add(this.lstCevap);
            this.Controls.Add(this.lstSoru);
            this.Controls.Add(this.lstDersler);
            this.Controls.Add(this.lstSoyad);
            this.Controls.Add(this.lstAd);
            this.Controls.Add(this.rdYanlis);
            this.Controls.Add(this.rdDogru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtSoru);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.RichTextBox rtxtSoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdDogru;
        private System.Windows.Forms.RadioButton rdYanlis;
        private System.Windows.Forms.ListBox lstAd;
        private System.Windows.Forms.ListBox lstSoyad;
        private System.Windows.Forms.ListBox lstDersler;
        private System.Windows.Forms.ListBox lstSoru;
        private System.Windows.Forms.ListBox lstCevap;
        private System.Windows.Forms.ListBox lstDurum;
        private System.Windows.Forms.Button BtnGoruntule;
        private System.Windows.Forms.CheckBox chkMatematik;
        private System.Windows.Forms.CheckBox chkFizik;
        private System.Windows.Forms.CheckBox chkKimya;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

