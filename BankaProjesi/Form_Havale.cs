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
    public partial class frmHavale : Form
    {
        public Banka banka;
        public GelirGiderRaporu rapor;
        Hesap gonderenHesap;
        Hesap alanHesap;

        public frmHavale(Hesap gonderenHesap)
        {
            InitializeComponent();
            this.gonderenHesap = gonderenHesap;
            txtTutar.Enabled = false;
            btnOnayla.Enabled = false;
        }

        private void btnHesBul_Click(object sender, EventArgs e)
        {
            ulong bulunacakHesapNo = Convert.ToUInt64(txtGondHesNo.Text);

            alanHesap = banka.HesapBul(bulunacakHesapNo);

            if (alanHesap != null)
            {
                txtGondBil.Text = "Ad: " + alanHesap.hangiMusteriyeAit.ad + "\r\nSoyad: " + alanHesap.hangiMusteriyeAit.soyad;
                txtTutar.Enabled = true;
                btnOnayla.Enabled = true;
                btnHesBul.Enabled = false;

            }
            else
                txtGondBil.Text = bulunacakHesapNo + " numaralı herhangi bir hesap bulunamamıştır.";
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            decimal girilenTutar = Convert.ToDecimal(txtTutar.Text);

            bool havaleOnay = gonderenHesap.hangiMusteriyeAit.ParaHavale(gonderenHesap, alanHesap, girilenTutar);

            if (havaleOnay)
            {
                txtDurumBilgisi.Text = "Havale işlemi gerçekleşti. İşlem sonrası toplam bakiye: " + Environment.NewLine + 
                                       ">>> " + gonderenHesap.bakiye + " ₺";
                btnOnayla.Enabled = false;
            }

            else
            {
                txtDurumBilgisi.Text = "Yetersiz bakiye. İşlem gerçekleştirelemedi. Toplam bakiye: " + Environment.NewLine +
                                       ">>> " + gonderenHesap.bakiye + " ₺";
            }
        }
    }
}
