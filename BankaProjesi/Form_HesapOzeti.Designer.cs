namespace BankaProjesi
{
    partial class frmHesapOzeti
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
            this.txtHesOzet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHesOzet
            // 
            this.txtHesOzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesOzet.Location = new System.Drawing.Point(12, 12);
            this.txtHesOzet.Multiline = true;
            this.txtHesOzet.Name = "txtHesOzet";
            this.txtHesOzet.Size = new System.Drawing.Size(561, 257);
            this.txtHesOzet.TabIndex = 0;
            this.txtHesOzet.TextChanged += new System.EventHandler(this.txtHesOzet_TextChanged);
            // 
            // frmHesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 281);
            this.Controls.Add(this.txtHesOzet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHesapOzeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HESAP ÖZETİ EKRANI";
            this.Load += new System.EventHandler(this.frmHesapOzeti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHesOzet;
    }
}