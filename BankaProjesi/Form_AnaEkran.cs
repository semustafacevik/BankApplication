using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaProjesi
{
    public partial class frmAnaEkran : Form
    {
        Banka AnaBanka = new Banka();
        public GelirGiderRaporu AnaRapor = new GelirGiderRaporu();

        public frmAnaEkran()
        {
            InitializeComponent();
            ButonAktivasyon_Gizle();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmYeniMusteri yeniMusteri = new frmYeniMusteri();
            yeniMusteri.MdiParent = this;
            yeniMusteri.StartPosition = FormStartPosition.CenterScreen;
            yeniMusteri.banka = AnaBanka;
            yeniMusteri.Show();
        }

        private void btnYeniHesap_Click(object sender, EventArgs e)
        {
            frmYeniHesap yeniHesap = new frmYeniHesap();
            yeniHesap.MdiParent = this;
            yeniHesap.StartPosition = FormStartPosition.CenterScreen;
            yeniHesap.banka = AnaBanka;
            yeniHesap.rapor = AnaRapor;
            yeniHesap.Show();
        }

        private void btnHesapIslemleri_Click(object sender, EventArgs e)
        {
            frmHesapIslemleri hesapIslemleri = new frmHesapIslemleri();
            hesapIslemleri.MdiParent = this;
            hesapIslemleri.StartPosition = FormStartPosition.CenterScreen;
            hesapIslemleri.banka = AnaBanka;
            hesapIslemleri.rapor = AnaRapor;
            hesapIslemleri.Show();
        }

        private void btnBankaRaporu_Click(object sender, EventArgs e)
        {
            ButonAktivasyon_Goster();
            dgvRapor.Rows[0].Cells[0].Value = AnaRapor.girenPara + " ₺ ";
            dgvRapor.Rows[0].Cells[1].Value = AnaRapor.cikanPara + " ₺ ";
            dgvRapor.Rows[0].Cells[2].Value = AnaRapor.toplamPara + " ₺ ";

        }

        private void btnRaporKapat_Click(object sender, EventArgs e)
        {
            ButonAktivasyon_Gizle();
        }

        /// <summary>
        /// İlgili butonların gösterildiği fonksiyon
        /// </summary>
        private void ButonAktivasyon_Goster()
        {
            dgvRapor.Show();
            lblRaporBaslik.Show();
            btnRaporKapat.Show();
        }

        /// <summary>
        /// İlgili fonksiyonların gizlendiği fonksiyon
        /// </summary>
        private void ButonAktivasyon_Gizle()
        {
            dgvRapor.Hide();
            lblRaporBaslik.Hide();
            btnRaporKapat.Hide();
        }
    }
}
