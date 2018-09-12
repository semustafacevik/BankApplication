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
    public partial class frmHesapIslemleri : Form
    {
        public Banka banka;

        public frmHesapIslemleri()
        {
            InitializeComponent();

            ButonAktivasyon_kapat();
            cmbHesNo.Enabled = false;
        }

        Hesap secilenHesap = null;

        private void btnParayatir_Click(object sender, EventArgs e)
        {
            frmParaYatirmaCekme paraYatirma = new frmParaYatirmaCekme(secilenHesap, "parayatirma");
            paraYatirma.Text = "PARA YATIRMA EKRANI";
            paraYatirma.ShowDialog();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            frmParaYatirmaCekme paraCekme = new frmParaYatirmaCekme(secilenHesap, "paracekme");
            paraCekme.Text = "PARA ÇEKME EKRANI";
            paraCekme.ShowDialog();
        }


        private void btnHesBul_Click(object sender, EventArgs e)
        {
            ulong bulunacakMusteriNo = Convert.ToUInt64(txtMusNo.Text);

            Musteri bulunacakMusteri = banka.MusteriBul(bulunacakMusteriNo);

            if (bulunacakMusteri != null)
            {
                foreach (Hesap ilgiliMusHesaplari in bulunacakMusteri.MusterininHesaplari)
                {
                    cmbHesNo.Items.Add(ilgiliMusHesaplari.hesapNumarasi);
                }

                cmbHesNo.Enabled = true;
                btnHesBul.Enabled = false;
            }

        }

        private void cmbHesaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ulong secilenHesapNo = Convert.ToUInt64(cmbHesNo.SelectedItem);

            secilenHesap = banka.HesapBul(secilenHesapNo);

            txtHesBilgileri.Text = "TCKN: " + secilenHesap.hangiMusteriyeait.TCKN + Environment.NewLine +
                                   "Ad Soyad:" + secilenHesap.hangiMusteriyeait.ad + " " + secilenHesap.hangiMusteriyeait.soyad + Environment.NewLine +
                                   secilenHesap.hesapNumarasi + " Numaralı Hesaptaki Bakiye: " + secilenHesap.bakiye + " ₺";

            ButonAktivasyon_ac();
        }

        private void ButonAktivasyon_ac()
        {
            btnParaYatir.Enabled = true;
            btnParaCek.Enabled = true;
            btnHavale.Enabled = true;
            btnHesKapat.Enabled = true;
            btnHesOzet.Enabled = true;
        }

        private void ButonAktivasyon_kapat()
        {
            btnParaYatir.Enabled = false;
            btnParaCek.Enabled = false;
            btnHavale.Enabled = false;
            btnHesKapat.Enabled = false;
            btnHesOzet.Enabled = false;
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            frm_Havale havale = new frm_Havale(secilenHesap);
            havale.banka = banka;
            havale.ShowDialog();
        }
    }
}
