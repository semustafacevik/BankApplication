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
            this.cmbHesNo = new System.Windows.Forms.ComboBox();
            this.btnHesOzet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHesBul
            // 
            this.btnHesBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesBul.Location = new System.Drawing.Point(23, 70);
            this.btnHesBul.Name = "btnHesBul";
            this.btnHesBul.Size = new System.Drawing.Size(119, 32);
            this.btnHesBul.TabIndex = 1;
            this.btnHesBul.Text = "BUL";
            this.btnHesBul.UseVisualStyleBackColor = true;
            this.btnHesBul.Click += new System.EventHandler(this.btnHesBul_Click);
            // 
            // txtMusNo
            // 
            this.txtMusNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusNo.Location = new System.Drawing.Point(23, 32);
            this.txtMusNo.MaxLength = 6;
            this.txtMusNo.Multiline = true;
            this.txtMusNo.Name = "txtMusNo";
            this.txtMusNo.Size = new System.Drawing.Size(164, 32);
            this.txtMusNo.TabIndex = 0;
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
            this.txtHesBilgileri.Location = new System.Drawing.Point(23, 178);
            this.txtHesBilgileri.Multiline = true;
            this.txtHesBilgileri.Name = "txtHesBilgileri";
            this.txtHesBilgileri.Size = new System.Drawing.Size(589, 205);
            this.txtHesBilgileri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hesap Bilgileri";
            // 
            // btnParaCek
            // 
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(351, 47);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(119, 32);
            this.btnParaCek.TabIndex = 5;
            this.btnParaCek.Text = "PARA ÇEK";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatir.Location = new System.Drawing.Point(213, 47);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(119, 32);
            this.btnParaYatir.TabIndex = 4;
            this.btnParaYatir.Text = "PARA YATIR";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParayatir_Click);
            // 
            // btnHavale
            // 
            this.btnHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavale.Location = new System.Drawing.Point(493, 47);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(119, 32);
            this.btnHavale.TabIndex = 6;
            this.btnHavale.Text = "HAVALE";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // btnHesKapat
            // 
            this.btnHesKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesKapat.Location = new System.Drawing.Point(424, 96);
            this.btnHesKapat.Name = "btnHesKapat";
            this.btnHesKapat.Size = new System.Drawing.Size(119, 32);
            this.btnHesKapat.TabIndex = 8;
            this.btnHesKapat.Text = "HESABI KAPAT";
            this.btnHesKapat.UseVisualStyleBackColor = true;
            this.btnHesKapat.Click += new System.EventHandler(this.btnHesKapat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Müşteri Numarası";
            // 
            // cmbHesNo
            // 
            this.cmbHesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHesNo.FormattingEnabled = true;
            this.cmbHesNo.Location = new System.Drawing.Point(23, 108);
            this.cmbHesNo.Name = "cmbHesNo";
            this.cmbHesNo.Size = new System.Drawing.Size(164, 33);
            this.cmbHesNo.Sorted = true;
            this.cmbHesNo.TabIndex = 2;
            this.cmbHesNo.Text = "Hesap Seçiniz";
            this.cmbHesNo.SelectedIndexChanged += new System.EventHandler(this.cmbHesaplar_SelectedIndexChanged);
            // 
            // btnHesOzet
            // 
            this.btnHesOzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesOzet.Location = new System.Drawing.Point(286, 96);
            this.btnHesOzet.Name = "btnHesOzet";
            this.btnHesOzet.Size = new System.Drawing.Size(119, 32);
            this.btnHesOzet.TabIndex = 7;
            this.btnHesOzet.Text = "HESAP ÖZETİ";
            this.btnHesOzet.UseVisualStyleBackColor = true;
            this.btnHesOzet.Click += new System.EventHandler(this.btnHesOzet_Click);
            // 
            // frmHesapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 397);
            this.Controls.Add(this.cmbHesNo);
            this.Controls.Add(this.btnHesOzet);
            this.Controls.Add(this.btnHesKapat);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.btnHesBul);
            this.Controls.Add(this.txtHesBilgileri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHesapIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HESAP İŞLEMLERİ EKRANI";
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
        private System.Windows.Forms.ComboBox cmbHesNo;
        private System.Windows.Forms.Button btnHesOzet;
    }
}