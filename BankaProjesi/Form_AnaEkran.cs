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
        Banka temelBanka = new Banka();
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmYeniMusteri yeniMusteri = new frmYeniMusteri();
            yeniMusteri.banka = temelBanka;
            yeniMusteri.ShowDialog();

        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniHesap_Click(object sender, EventArgs e)
        {
            frmYeniHesap yeniHesap = new frmYeniHesap();
            yeniHesap.banka = temelBanka;
            yeniHesap.ShowDialog();
        }

        private void btnHesapIslemleri_Click(object sender, EventArgs e)
        {
            frmHesapIslemleri hesapIslemleri = new frmHesapIslemleri();
            hesapIslemleri.banka = temelBanka;
            hesapIslemleri.ShowDialog();
        }
    }
}
