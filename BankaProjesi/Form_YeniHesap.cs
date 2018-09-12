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

        private Musteri hesapAcilacakmusteri = null;

        private void btnMusBul_Click(object sender, EventArgs e)
        {
            ulong aranacakMusterino = Convert.ToUInt64(txtMusteriNo.Text);

            foreach (Musteri arananMusteri in banka.Musteriler)
            {
                if (arananMusteri.musteriNosu == aranacakMusterino)
                {
                    MusteriBilgileriniYazdırma(arananMusteri);
                    btnHesapAc.Enabled = true;
                    btnMusBul.Enabled = false;
                    hesapAcilacakmusteri = arananMusteri;
                    break;
                }
            }
        }

        private void MusteriBilgileriniYazdırma(Musteri bulunanMusteri)
        {
            txtMusteriBilgileri.Text = "TCKN: " + bulunanMusteri.TCKN.ToString() + Environment.NewLine +
                                       "Ad Soyad: " + bulunanMusteri.ad + " " + bulunanMusteri.soyad + Environment.NewLine +
                                       "Müşteri Türü: " + bulunanMusteri.musteriTuru;
        }

        private ulong hesapNo = 0;

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            Random randHesapNo = new Random();

            if(hesapAcilacakmusteri.musteriTuru == "Bireysel Müşteri")
            {
                hesapNo = Convert.ToUInt64(randHesapNo.Next(1000000, 5000000));
                Hesap yeniHesap = IlgiliMusteriyeHesapBilgileriniKaydetme(hesapNo);
                banka.BankayaHesapEkle(yeniHesap);
            } 

            else if(hesapAcilacakmusteri.musteriTuru == "Ticari Müşteri")
            {
                hesapNo = Convert.ToUInt64(randHesapNo.Next(5000000, 10000000));
                Hesap yeniHesap = IlgiliMusteriyeHesapBilgileriniKaydetme(hesapNo);
                banka.BankayaHesapEkle(yeniHesap);
            }

            else
            {
                // hatalı
            }

            btnHesapAc.Hide();
            lblHesapNo.Show();
            lblHesapNo.Text = hesapNo.ToString();
        }

        private Hesap IlgiliMusteriyeHesapBilgileriniKaydetme(ulong hesapNumarasi)
        {
            Hesap yeniHesap = new Hesap();
            yeniHesap.hesapNumarasi = hesapNo;
            yeniHesap.ekHesap = 100;
            yeniHesap.hangiMusteriyeait = hesapAcilacakmusteri;
            hesapAcilacakmusteri.MusteriyeHesapEkle(yeniHesap);

            return yeniHesap;
        }

        private void lblHesapNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
