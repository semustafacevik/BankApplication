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
    public partial class frm_Havale : Form
    {
        public Banka banka;
        private Hesap gonderenHesap;
        private Hesap alanHesap;

        public frm_Havale(Hesap gonderenHesap)
        {
            InitializeComponent();

            this.gonderenHesap = gonderenHesap;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            ulong bulunacakHesapNo = Convert.ToUInt32(txtGondHesNo.Text);

            alanHesap = banka.HesapBul(bulunacakHesapNo);

            if (alanHesap != null)
            {
                txtGondHesBil.Text = "Ad Soyad: " + alanHesap.hangiMusteriyeait.ad + " " + alanHesap.hangiMusteriyeait.soyad;
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            decimal girilenTutar = Convert.ToDecimal(txtTutar.Text);

            gonderenHesap.hangiMusteriyeait.HesaptanParaCek(gonderenHesap, girilenTutar);
            alanHesap.hangiMusteriyeait.HesabaParaYatir(alanHesap, girilenTutar);

            txtDurumBilgisi.Text = "Gond: " + gonderenHesap.bakiye + "    Alan: " + alanHesap.bakiye;
        }
    }
}
