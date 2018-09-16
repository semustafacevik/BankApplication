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
        public frmAnaEkran()
        {
            InitializeComponent();
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
            yeniHesap.Show();
        }

        private void btnHesapIslemleri_Click(object sender, EventArgs e)
        {
            frmHesapIslemleri hesapIslemleri = new frmHesapIslemleri();
            hesapIslemleri.MdiParent = this;
            hesapIslemleri.StartPosition = FormStartPosition.CenterScreen;
            hesapIslemleri.banka = AnaBanka;
            hesapIslemleri.Show();
        }
    }
}
