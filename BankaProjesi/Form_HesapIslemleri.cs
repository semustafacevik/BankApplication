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
        public GelirGiderRaporu rapor;

        public frmHesapIslemleri()
        {
            InitializeComponent();

            ButonAktivasyon_Kapat();
            cmbHesNo.Enabled = false;
        }

        Hesap secilenHesap;

        private void btnHesBul_Click(object sender, EventArgs e)
        {
            ulong bulunacakMusNo = Convert.ToUInt64(txtMusNo.Text);

            Musteri ilgiliMusteri = banka.MusteriBul(bulunacakMusNo);

            if (ilgiliMusteri != null)
            {
                foreach (Hesap ilgiliMusHesaplari in ilgiliMusteri.MusterininHesaplari)
                {
                    cmbHesNo.Items.Add(ilgiliMusHesaplari.hesapNumarasi);
                }

                cmbHesNo.Enabled = true;
                btnHesBul.Enabled = false;
            }

            else
                txtHesBilgileri.Text = bulunacakMusNo + " numaralı herhangi bir müşteri bulunamadı.";

        }

        private void cmbHesaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ulong secilenHesNo = Convert.ToUInt64(cmbHesNo.SelectedItem);

            secilenHesap = banka.HesapBul(secilenHesNo);

            if (secilenHesap != null)
            {
                txtHesBilgileri.Text = "TCKN: " + secilenHesap.hangiMusteriyeAit.TCKN + Environment.NewLine +
                                       "Ad Soyad: " + secilenHesap.hangiMusteriyeAit.ad + " " + secilenHesap.hangiMusteriyeAit.soyad + Environment.NewLine +
                                       secilenHesap.hesapNumarasi + " Numaralı Hesaptaki Bakiye: " + secilenHesap.bakiye + " ₺ - (Ek hesap: " + secilenHesap.ekHesap + " ₺)";
                ButonAktivasyon_Ac();
            }

            else
                txtHesBilgileri.Text = secilenHesap + " numaralı herhangi bir hesap bulunamadı.";
            
        }

        private void btnParayatir_Click(object sender, EventArgs e)
        {
            frmParaYatirmaCekme paraYatirma = new frmParaYatirmaCekme(secilenHesap, "parayatirma");
            paraYatirma.MdiParent = ActiveForm;
            paraYatirma.StartPosition = FormStartPosition.CenterScreen;
            paraYatirma.Text = "PARA YATIRMA EKRANI";
            paraYatirma.rapor = rapor;
            paraYatirma.Show();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            frmParaYatirmaCekme paraCekme = new frmParaYatirmaCekme(secilenHesap, "paracekme");
            paraCekme.MdiParent = ActiveForm;
            paraCekme.StartPosition = FormStartPosition.CenterScreen;
            paraCekme.Text = "PARA ÇEKME EKRANI";
            paraCekme.rapor = rapor;
            paraCekme.Show();
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            frmHavale havale = new frmHavale(secilenHesap);
            havale.MdiParent = ActiveForm;
            havale.StartPosition = FormStartPosition.CenterScreen;
            havale.banka = banka;
            havale.rapor = rapor;
            havale.Show();
        }

        private void btnHesOzet_Click(object sender, EventArgs e)
        {
            txtHesBilgileri.Clear();
            txtHesBilgileri.Text += secilenHesap.HesapOzetiYazdir();
        }

        private void btnHesKapat_Click(object sender, EventArgs e)
        {
            if (secilenHesap.bakiye == 0 && secilenHesap.ekHesap == 0)
            {
                txtHesBilgileri.Text = secilenHesap.hesapNumarasi + " hesap numaralı hesap kapatıldı.";
                cmbHesNo.Text = "Hesap Seçiniz";
                cmbHesNo.Items.Remove(secilenHesap.hesapNumarasi);
                banka.BankadanHesapSil(secilenHesap);
                secilenHesap.hangiMusteriyeAit.MusteridenHesapSil(secilenHesap);
                ButonAktivasyon_Kapat();
            }

            else if (secilenHesap.bakiye == 0 && secilenHesap.ekHesap != 0)
            {
                txtHesBilgileri.Text = secilenHesap.hesapNumarasi + " hesap numaralı hesabın ek hesabında bir miktar para bulunmaktadır.\r\n>>> Ek hesap: " + secilenHesap.ekHesap + " ₺" + Environment.NewLine +
                                       "Hesap katılamadı, hesabın kapanması için hesapta para bulunmaması gerekmektedir.";
            }

            else
            {
                txtHesBilgileri.Text = secilenHesap.hesapNumarasi + " hesap numaralı hesapta bir miktar para bulunmaktadır.\r\n>>> Bakiye: " + secilenHesap.bakiye + " ₺ - (Ek hesap: " + secilenHesap.ekHesap + " ₺)" + Environment.NewLine +
                                       "Hesap katılamadı, hesabın kapanması için hesapta para bulunmaması gerekmektedir.";
            }
        }

        /// <summary>
        /// İlgili butonların gösterildiği fonksiyon
        /// </summary>
        private void ButonAktivasyon_Ac()
        {
            btnParaYatir.Enabled = true;
            btnParaCek.Enabled = true;
            btnHavale.Enabled = true;
            btnHesKapat.Enabled = true;
            btnHesOzet.Enabled = true;
        }

        /// <summary>
        /// İlgili butonların gizlendiği fonksiyon
        /// </summary>
        private void ButonAktivasyon_Kapat()
        {
            btnParaYatir.Enabled = false;
            btnParaCek.Enabled = false;
            btnHavale.Enabled = false;
            btnHesKapat.Enabled = false;
            btnHesOzet.Enabled = false;
        }
    }
}
