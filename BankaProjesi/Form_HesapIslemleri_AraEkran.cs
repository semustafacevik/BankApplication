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

            if (secilenHesap != null)
            {
                txtHesBilgileri.Text = "TCKN: " + secilenHesap.hangiMusteriyeait.TCKN + Environment.NewLine +
                                       "Ad Soyad:" + secilenHesap.hangiMusteriyeait.ad + " " + secilenHesap.hangiMusteriyeait.soyad + Environment.NewLine +
                                       secilenHesap.hesapNumarasi + " Numaralı Hesaptaki Bakiye: " + secilenHesap.bakiye + " ₺";
                ButonAktivasyon_ac();
            }
            
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
            frmHavale havale = new frmHavale(secilenHesap);
            havale.banka = banka;
            havale.ShowDialog();
        }

        private void btnHesOzet_Click(object sender, EventArgs e)
        {
            frmHesapOzeti hesapOzeti = new frmHesapOzeti(secilenHesap);
            hesapOzeti.banka = banka;
            hesapOzeti.ShowDialog();

        }

        private void btnHesKapat_Click(object sender, EventArgs e)
        {
            if (secilenHesap.bakiye == 0 && secilenHesap.ekHesap == 0)
            {
                txtHesBilgileri.Text = secilenHesap.hesapNumarasi + " hesap numaralı hesap kapatıldı.";

                banka.BankadanHesapSil(secilenHesap);
                secilenHesap.hangiMusteriyeait.MusteridenHesapSil(secilenHesap);
                ButonAktivasyon_kapat();
            }

            else if (secilenHesap.bakiye == 0 && secilenHesap.ekHesap != 0)
            {
                txtHesBilgileri.Text = secilenHesap.hesapNumarasi + " hesap numaralı hesabın ek hesabında para bulunmaktadır. (Ek hesap: " + secilenHesap.ekHesap + " ₺)" + Environment.NewLine +
                                       "Hesap katılamadı, hesabın kapanması için hesapta para bulunmaması gerekmektedir";
            }

            else
            {
                txtHesBilgileri.Text = secilenHesap.hesapNumarasi + " hesap numaralı hesapta para bulunmaktadır. (Bakiye: " + secilenHesap.bakiye + " ₺ - Ek hesap: " + secilenHesap.ekHesap + " ₺)" + Environment.NewLine +
                                       "Hesap katılamadı, hesabın kapanması için hesapta para bulunmaması gerekmektedir";
            }
        }
    }
}
