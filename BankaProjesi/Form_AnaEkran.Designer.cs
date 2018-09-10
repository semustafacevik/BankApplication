namespace BankaProjesi
{
    partial class frmAnaEkran
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
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnBankaRaporu = new System.Windows.Forms.Button();
            this.btnHesapIslemleri = new System.Windows.Forms.Button();
            this.btnYeniHesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMusteri.Location = new System.Drawing.Point(39, 12);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(120, 44);
            this.btnYeniMusteri.TabIndex = 0;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnBankaRaporu
            // 
            this.btnBankaRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaRaporu.Location = new System.Drawing.Point(582, 12);
            this.btnBankaRaporu.Name = "btnBankaRaporu";
            this.btnBankaRaporu.Size = new System.Drawing.Size(120, 44);
            this.btnBankaRaporu.TabIndex = 3;
            this.btnBankaRaporu.Text = "Banka Raporu";
            this.btnBankaRaporu.UseVisualStyleBackColor = true;
            // 
            // btnHesapIslemleri
            // 
            this.btnHesapIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapIslemleri.Location = new System.Drawing.Point(400, 12);
            this.btnHesapIslemleri.Name = "btnHesapIslemleri";
            this.btnHesapIslemleri.Size = new System.Drawing.Size(120, 44);
            this.btnHesapIslemleri.TabIndex = 2;
            this.btnHesapIslemleri.Text = "Hesap İşlemleri";
            this.btnHesapIslemleri.UseVisualStyleBackColor = true;
            this.btnHesapIslemleri.Click += new System.EventHandler(this.btnHesapIslemleri_Click);
            // 
            // btnYeniHesap
            // 
            this.btnYeniHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniHesap.Location = new System.Drawing.Point(213, 12);
            this.btnYeniHesap.Name = "btnYeniHesap";
            this.btnYeniHesap.Size = new System.Drawing.Size(120, 44);
            this.btnYeniHesap.TabIndex = 1;
            this.btnYeniHesap.Text = "Yeni Hesap";
            this.btnYeniHesap.UseVisualStyleBackColor = true;
            this.btnYeniHesap.Click += new System.EventHandler(this.btnYeniHesap_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 387);
            this.Controls.Add(this.btnYeniHesap);
            this.Controls.Add(this.btnHesapIslemleri);
            this.Controls.Add(this.btnBankaRaporu);
            this.Controls.Add(this.btnYeniMusteri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnaEkran";
            this.Text = "ANA EKRAN";
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnBankaRaporu;
        private System.Windows.Forms.Button btnHesapIslemleri;
        private System.Windows.Forms.Button btnYeniHesap;
    }
}

