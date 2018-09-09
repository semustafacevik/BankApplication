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
        }

        private Musteri hesapAcilacakmusteri = null;

        private void btnMusBul_Click(object sender, EventArgs e)
        {
            ulong aranacakMusterino = Convert.ToUInt32(txtMusteriNo.Text);

            foreach (Musteri arananMusteri in banka.musteriler)
            {
                if(arananMusteri.musteriNosu == aranacakMusterino)
                {
                    MusteriBilgileriniYazdırma(arananMusteri);
                    btnHesapAc.Enabled = true;
                    hesapAcilacakmusteri = arananMusteri;
                }
            }

        }

        private void MusteriBilgileriniYazdırma(Musteri bulunanMusteri)
        {
            txtMusteriBilgileri.Text = bulunanMusteri.TCNo.ToString() + Environment.NewLine +
                                       bulunanMusteri.ad + " " + bulunanMusteri.soyad + Environment.NewLine +
                                       bulunanMusteri.musteriTuru;
        }

        private ulong hesapNo = 0;

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            Random randHesapNo = new Random();

            if(hesapAcilacakmusteri.musteriTuru == "Bireysel Müşteri")
            {
                hesapNo = Convert.ToUInt32(randHesapNo.Next(1000000, 5000000));
                IlgiliMusteriyeHesapBilgileriniKaydetme(hesapNo, 50);
            } 

            else if(hesapAcilacakmusteri.musteriTuru == "Ticari Müşteri")
            {
                hesapNo = Convert.ToUInt32(randHesapNo.Next(5000000, 10000000));
                IlgiliMusteriyeHesapBilgileriniKaydetme(hesapNo, 100);
            }

            else
            {
                // hatalı
            }

            txtMusteriBilgileri.Text = hesapAcilacakmusteri.TCNo + " TCKN'lu müşteriye " + hesapNo + " numaralı hesap açılmıştır.";
        }

        private void IlgiliMusteriyeHesapBilgileriniKaydetme(ulong hesapNumarasi, decimal tutar)
        {
            Hesap yeniHesap = new Hesap();
            yeniHesap.hesapNumarasi = hesapNo;
            yeniHesap.ekHesap = tutar;
            hesapAcilacakmusteri.MusteriyeHesapEkle(yeniHesap);
        }
    }
}
