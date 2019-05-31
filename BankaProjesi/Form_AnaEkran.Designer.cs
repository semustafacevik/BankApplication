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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnBankaRaporu = new System.Windows.Forms.Button();
            this.btnHesapIslemleri = new System.Windows.Forms.Button();
            this.btnYeniHesap = new System.Windows.Forms.Button();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.girenPara = new System.Windows.Forms.DataGridViewLinkColumn();
            this.çikanPara = new System.Windows.Forms.DataGridViewLinkColumn();
            this.toplamPara = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblRaporBaslik = new System.Windows.Forms.Label();
            this.btnRaporKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
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
            this.btnBankaRaporu.Click += new System.EventHandler(this.btnBankaRaporu_Click);
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
            // dgvRapor
            // 
            this.dgvRapor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.girenPara,
            this.çikanPara,
            this.toplamPara});
            this.dgvRapor.Location = new System.Drawing.Point(110, 144);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.Size = new System.Drawing.Size(527, 44);
            this.dgvRapor.TabIndex = 4;
            // 
            // girenPara
            // 
            this.girenPara.ActiveLinkColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girenPara.DefaultCellStyle = dataGridViewCellStyle1;
            this.girenPara.Frozen = true;
            this.girenPara.HeaderText = "BANKAYA GİREN PARA";
            this.girenPara.LinkColor = System.Drawing.Color.Black;
            this.girenPara.Name = "girenPara";
            this.girenPara.VisitedLinkColor = System.Drawing.Color.Black;
            this.girenPara.Width = 155;
            // 
            // çikanPara
            // 
            this.çikanPara.ActiveLinkColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çikanPara.DefaultCellStyle = dataGridViewCellStyle2;
            this.çikanPara.Frozen = true;
            this.çikanPara.HeaderText = "BANKADAN ÇIKAN PARA";
            this.çikanPara.LinkColor = System.Drawing.Color.Black;
            this.çikanPara.Name = "çikanPara";
            this.çikanPara.VisitedLinkColor = System.Drawing.Color.Black;
            this.çikanPara.Width = 160;
            // 
            // toplamPara
            // 
            this.toplamPara.ActiveLinkColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamPara.DefaultCellStyle = dataGridViewCellStyle3;
            this.toplamPara.Frozen = true;
            this.toplamPara.HeaderText = "BANKADAKİ TOPLAM PARA";
            this.toplamPara.LinkColor = System.Drawing.Color.Black;
            this.toplamPara.Name = "toplamPara";
            this.toplamPara.VisitedLinkColor = System.Drawing.Color.Black;
            this.toplamPara.Width = 170;
            // 
            // lblRaporBaslik
            // 
            this.lblRaporBaslik.AutoSize = true;
            this.lblRaporBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRaporBaslik.Location = new System.Drawing.Point(114, 116);
            this.lblRaporBaslik.Name = "lblRaporBaslik";
            this.lblRaporBaslik.Size = new System.Drawing.Size(169, 25);
            this.lblRaporBaslik.TabIndex = 10;
            this.lblRaporBaslik.Text = "BANKA RAPORU";
            // 
            // btnRaporKapat
            // 
            this.btnRaporKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporKapat.Location = new System.Drawing.Point(452, 190);
            this.btnRaporKapat.Name = "btnRaporKapat";
            this.btnRaporKapat.Size = new System.Drawing.Size(185, 37);
            this.btnRaporKapat.TabIndex = 5;
            this.btnRaporKapat.Text = "RAPORU KAPAT";
            this.btnRaporKapat.UseVisualStyleBackColor = true;
            this.btnRaporKapat.Click += new System.EventHandler(this.btnRaporKapat_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 561);
            this.Controls.Add(this.lblRaporBaslik);
            this.Controls.Add(this.btnRaporKapat);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.btnYeniHesap);
            this.Controls.Add(this.btnHesapIslemleri);
            this.Controls.Add(this.btnBankaRaporu);
            this.Controls.Add(this.btnYeniMusteri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA EKRAN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnBankaRaporu;
        private System.Windows.Forms.Button btnHesapIslemleri;
        private System.Windows.Forms.Button btnYeniHesap;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Label lblRaporBaslik;
        private System.Windows.Forms.Button btnRaporKapat;
        private System.Windows.Forms.DataGridViewLinkColumn girenPara;
        private System.Windows.Forms.DataGridViewLinkColumn çikanPara;
        private System.Windows.Forms.DataGridViewLinkColumn toplamPara;
    }
}

