namespace BankaProjesi
{
    partial class frmYeniHesap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusNo = new System.Windows.Forms.TextBox();
            this.btnMusBul = new System.Windows.Forms.Button();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.txtMusBilgileri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Müşteri Numarası";
            // 
            // txtMusNo
            // 
            this.txtMusNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusNo.Location = new System.Drawing.Point(21, 40);
            this.txtMusNo.MaxLength = 6;
            this.txtMusNo.Multiline = true;
            this.txtMusNo.Name = "txtMusNo";
            this.txtMusNo.Size = new System.Drawing.Size(190, 32);
            this.txtMusNo.TabIndex = 0;
            // 
            // btnMusBul
            // 
            this.btnMusBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusBul.Location = new System.Drawing.Point(21, 78);
            this.btnMusBul.Name = "btnMusBul";
            this.btnMusBul.Size = new System.Drawing.Size(92, 46);
            this.btnMusBul.TabIndex = 1;
            this.btnMusBul.Text = "BUL";
            this.btnMusBul.UseVisualStyleBackColor = true;
            this.btnMusBul.Click += new System.EventHandler(this.btnMusBul_Click);
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapAc.Location = new System.Drawing.Point(119, 78);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(92, 46);
            this.btnHesapAc.TabIndex = 2;
            this.btnHesapAc.Text = "HESAP AÇ";
            this.btnHesapAc.UseVisualStyleBackColor = true;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // txtMusBilgileri
            // 
            this.txtMusBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusBilgileri.Location = new System.Drawing.Point(229, 40);
            this.txtMusBilgileri.Multiline = true;
            this.txtMusBilgileri.Name = "txtMusBilgileri";
            this.txtMusBilgileri.Size = new System.Drawing.Size(284, 84);
            this.txtMusBilgileri.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(226, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Müşteri Bilgileri";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapNo.Location = new System.Drawing.Point(122, 86);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(89, 25);
            this.lblHesapNo.TabIndex = 3;
            this.lblHesapNo.Text = "1234567";
            this.lblHesapNo.Click += new System.EventHandler(this.lblHesapNo_Click);
            // 
            // frmYeniHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 141);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.btnMusBul);
            this.Controls.Add(this.txtMusBilgileri);
            this.Controls.Add(this.txtMusNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHesapNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYeniHesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YENİ HESAP AÇMA EKRANI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusNo;
        private System.Windows.Forms.Button btnMusBul;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.TextBox txtMusBilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHesapNo;
    }
}