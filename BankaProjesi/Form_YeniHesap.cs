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
    public partial class frmYeniHesap : Form
    {
        public Banka banka;
        public frmYeniHesap()
        {
            InitializeComponent();
            btnHesapAc.Enabled = false;
            lblHesapNo.Hide();
        }

        Hesap yeniHesap = null;
        Musteri bulunacakMusteri = null;
        ulong hesapNo;
        Random randHesapNo = new Random();
        DateTime islemTarihi;

        private void btnMusBul_Click(object sender, EventArgs e)
        {
            ulong aranacakMusterino = Convert.ToUInt64(txtMusteriNo.Text);

            bulunacakMusteri = banka.MusteriBul(aranacakMusterino);

            if (bulunacakMusteri != null)
            {
                MusteriBilgileriniYazdırma();
                btnHesapAc.Enabled = true;
                btnMusBul.Enabled = false;
            }
        }

        private void MusteriBilgileriniYazdırma()
        {
            txtMusteriBilgileri.Text = "TCKN: " + bulunacakMusteri.TCKN.ToString() + Environment.NewLine +
                                       "Ad Soyad: " + bulunacakMusteri.ad + " " + bulunacakMusteri.soyad + Environment.NewLine +
                                       "Müşteri Türü: " + bulunacakMusteri.musteriTuru;
        }
      
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            islemTarihi = DateTime.Now;
            if (bulunacakMusteri.musteriTuru == "Bireysel Müşteri")
            {
                hesapNo = Convert.ToUInt64(randHesapNo.Next(1000000, 5000000));
                FarkliHesapNumarasiUretme(1000000, 5000000);
                HesapBilgileriniKaydetme();
            } 

            else if(bulunacakMusteri.musteriTuru == "Ticari Müşteri")
            {
                hesapNo = Convert.ToUInt64(randHesapNo.Next(5000000, 10000000));
                FarkliHesapNumarasiUretme(5000000, 10000000);
                HesapBilgileriniKaydetme();
            }

            else
            {
                // hatalı
            }

            btnHesapAc.Hide();
            lblHesapNo.Show();
            lblHesapNo.Text = hesapNo.ToString();

            HesapOzeti hesapOzeti = new HesapOzeti(yeniHesap, "Hesap Açma", 0, islemTarihi);
            yeniHesap.HesapOzetiEkle(hesapOzeti);
        }

        private void HesapBilgileriniKaydetme()
        {
            yeniHesap = new Hesap();
            yeniHesap.hesapNumarasi = hesapNo;
            yeniHesap.ekHesap = 100;
            yeniHesap.hangiMusteriyeait = bulunacakMusteri;
            bulunacakMusteri.MusteriyeHesapEkle(yeniHesap);
            banka.BankayaHesapEkle(yeniHesap);
        }

        private void FarkliHesapNumarasiUretme(int minDeger, int maxDeger)
        {
            foreach (Hesap mevcutHesaplar in banka.Hesaplar)
            {
                while (hesapNo == mevcutHesaplar.hesapNumarasi)
                {
                    hesapNo = Convert.ToUInt32(randHesapNo.Next(minDeger, maxDeger));
                    FarkliHesapNumarasiUretme(minDeger, maxDeger);
                }
            }
        }

        private void lblHesapNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
