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
            ulong aranacakMusterino = Convert.ToUInt64(txtMusteriNo.Text);

            foreach (Musteri arananMusteri in banka.Musteriler)
            {
                if (arananMusteri.musteriNosu == aranacakMusterino)
                {
                    MusteriBilgileriniYazdırma(arananMusteri);
                    btnHesapAc.Enabled = true;
                    hesapAcilacakmusteri = arananMusteri;
                    break;
                }

                //else
                //{
                //    txtMusteriBilgileri.Text = aranacakMusterino + " müşteri numarasına sahip herhangi bir müşteri bulunamadı.";
                //}
            }
        }

        private void MusteriBilgileriniYazdırma(Musteri bulunanMusteri)
        {
            txtMusteriBilgileri.Text = bulunanMusteri.TCKN.ToString() + Environment.NewLine +
                                       bulunanMusteri.ad + " " + bulunanMusteri.soyad + Environment.NewLine +
                                       bulunanMusteri.musteriTuru;
        }

        private ulong hesapNo = 0;

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            Random randHesapNo = new Random();

            if(hesapAcilacakmusteri.musteriTuru == "Bireysel Müşteri")
            {
                hesapNo = Convert.ToUInt64(randHesapNo.Next(1000000, 5000000));
                Hesap yeniHesap = IlgiliMusteriyeHesapBilgileriniKaydetme(hesapNo, 50);
                banka.BankayaHesapEkle(yeniHesap);
            } 

            else if(hesapAcilacakmusteri.musteriTuru == "Ticari Müşteri")
            {
                hesapNo = Convert.ToUInt64(randHesapNo.Next(5000000, 10000000));
                Hesap yeniHesap = IlgiliMusteriyeHesapBilgileriniKaydetme(hesapNo, 100);
                banka.BankayaHesapEkle(yeniHesap);
            }

            else
            {
                // hatalı
            }

            txtMusteriBilgileri.Text = hesapAcilacakmusteri.TCKN + " TCKN'lu müşteriye " + hesapNo + " numaralı hesap açılmıştır.";
        }

        private Hesap IlgiliMusteriyeHesapBilgileriniKaydetme(ulong hesapNumarasi, decimal tutar)
        {
            Hesap yeniHesap = new Hesap();
            yeniHesap.hesapNumarasi = hesapNo;
            yeniHesap.ekHesap = tutar;
            yeniHesap.hangiMusteriyeait = hesapAcilacakmusteri;
            hesapAcilacakmusteri.MusteriyeHesapEkle(yeniHesap);

            return yeniHesap;
        }
    }
}
