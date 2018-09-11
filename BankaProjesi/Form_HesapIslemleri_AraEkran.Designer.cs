namespace BankaProjesi
{
    partial class frmHesapIslemleri
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
            this.btnHesBul = new System.Windows.Forms.Button();
            this.txtMusNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHesBilgileri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.btnHavale = new System.Windows.Forms.Button();
            this.btnHesKapat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtGondHesNo = new System.Windows.Forms.TextBox();
            this.lblGonHesNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDurumBilgisi = new System.Windows.Forms.TextBox();
            this.cmbHesNo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHesBul
            // 
            this.btnHesBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesBul.Location = new System.Drawing.Point(23, 66);
            this.btnHesBul.Name = "btnHesBul";
            this.btnHesBul.Size = new System.Drawing.Size(119, 32);
            this.btnHesBul.TabIndex = 13;
            this.btnHesBul.Text = "BUL";
            this.btnHesBul.UseVisualStyleBackColor = true;
            this.btnHesBul.Click += new System.EventHandler(this.btnHesBul_Click);
            // 
            // txtMusNo
            // 
            this.txtMusNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusNo.Location = new System.Drawing.Point(23, 31);
            this.txtMusNo.MaxLength = 6;
            this.txtMusNo.Multiline = true;
            this.txtMusNo.Name = "txtMusNo";
            this.txtMusNo.Size = new System.Drawing.Size(176, 32);
            this.txtMusNo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hesap Numarası";
            // 
            // txtHesBilgileri
            // 
            this.txtHesBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesBilgileri.Location = new System.Drawing.Point(23, 181);
            this.txtHesBilgileri.MaxLength = 7;
            this.txtHesBilgileri.Multiline = true;
            this.txtHesBilgileri.Name = "txtHesBilgileri";
            this.txtHesBilgileri.Size = new System.Drawing.Size(324, 118);
            this.txtHesBilgileri.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hesap Bilgileri";
            // 
            // btnParaCek
            // 
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(228, 57);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(119, 32);
            this.btnParaCek.TabIndex = 13;
            this.btnParaCek.Text = "PARA ÇEK";
            this.btnParaCek.UseVisualStyleBackColor = true;
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatir.Location = new System.Drawing.Point(228, 19);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(119, 32);
            this.btnParaYatir.TabIndex = 13;
            this.btnParaYatir.Text = "PARA YATIR";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParayatir_Click);
            // 
            // btnHavale
            // 
            this.btnHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavale.Location = new System.Drawing.Point(228, 92);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(119, 32);
            this.btnHavale.TabIndex = 13;
            this.btnHavale.Text = "HAVALE";
            this.btnHavale.UseVisualStyleBackColor = true;
            // 
            // btnHesKapat
            // 
            this.btnHesKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesKapat.Location = new System.Drawing.Point(228, 130);
            this.btnHesKapat.Name = "btnHesKapat";
            this.btnHesKapat.Size = new System.Drawing.Size(119, 32);
            this.btnHesKapat.TabIndex = 13;
            this.btnHesKapat.Text = "HESABI KAPAT";
            this.btnHesKapat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Müşteri Numarası";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(560, 102);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(119, 32);
            this.btnOnayla.TabIndex = 18;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            // 
            // txtGondHesNo
            // 
            this.txtGondHesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGondHesNo.Location = new System.Drawing.Point(481, 29);
            this.txtGondHesNo.MaxLength = 7;
            this.txtGondHesNo.Multiline = true;
            this.txtGondHesNo.Name = "txtGondHesNo";
            this.txtGondHesNo.Size = new System.Drawing.Size(208, 33);
            this.txtGondHesNo.TabIndex = 16;
            // 
            // lblGonHesNo
            // 
            this.lblGonHesNo.AutoSize = true;
            this.lblGonHesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGonHesNo.Location = new System.Drawing.Point(476, 9);
            this.lblGonHesNo.Name = "lblGonHesNo";
            this.lblGonHesNo.Size = new System.Drawing.Size(201, 17);
            this.lblGonHesNo.TabIndex = 20;
            this.lblGonHesNo.Text = "Gönderilecek Hesap Numarası";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(491, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(470, 103);
            this.txtTutar.MaxLength = 7;
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(84, 32);
            this.txtTutar.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(388, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Durum Bilgisi";
            // 
            // txtDurumBilgisi
            // 
            this.txtDurumBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDurumBilgisi.Location = new System.Drawing.Point(391, 181);
            this.txtDurumBilgisi.MaxLength = 7;
            this.txtDurumBilgisi.Multiline = true;
            this.txtDurumBilgisi.Name = "txtDurumBilgisi";
            this.txtDurumBilgisi.Size = new System.Drawing.Size(208, 118);
            this.txtDurumBilgisi.TabIndex = 12;
            // 
            // cmbHesNo
            // 
            this.cmbHesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHesNo.FormattingEnabled = true;
            this.cmbHesNo.Location = new System.Drawing.Point(23, 102);
            this.cmbHesNo.Name = "cmbHesNo";
            this.cmbHesNo.Size = new System.Drawing.Size(176, 33);
            this.cmbHesNo.Sorted = true;
            this.cmbHesNo.TabIndex = 23;
            this.cmbHesNo.Text = "Hesap Seçiniz";
            this.cmbHesNo.SelectedIndexChanged += new System.EventHandler(this.cmbHesaplar_SelectedIndexChanged);
            // 
            // frmHesapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 311);
            this.Controls.Add(this.cmbHesNo);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtGondHesNo);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGonHesNo);
            this.Controls.Add(this.btnHesKapat);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.btnHesBul);
            this.Controls.Add(this.txtDurumBilgisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHesBilgileri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHesapIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HESAP İŞLEMLERİ EKRANI";
            this.Load += new System.EventHandler(this.frmHesapIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesBul;
        private System.Windows.Forms.TextBox txtMusNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHesBilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Button btnHesKapat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtGondHesNo;
        private System.Windows.Forms.Label lblGonHesNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDurumBilgisi;
        private System.Windows.Forms.ComboBox cmbHesNo;
    }
}