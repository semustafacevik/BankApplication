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
        public GelirGiderRaporu rapor;

        public frmYeniHesap()
        {
            InitializeComponent();
            btnHesapAc.Enabled = false;
            lblHesapNo.Hide();
        }

        Hesap yeniHesap;
        Musteri ilgiliMusteri;
        ulong hesapNo;
        Random randHesapNo = new Random();
        HesapOzeti hesapOzeti;
        DateTime islemTarihi;

        private void btnMusBul_Click(object sender, EventArgs e)
        {
            ulong aranacakMusNo = Convert.ToUInt64(txtMusNo.Text);

            ilgiliMusteri = banka.MusteriBul(aranacakMusNo);

            if (ilgiliMusteri != null)
            {
                MusteriBilgileriniYazdir();
                btnHesapAc.Enabled = true;
                btnMusBul.Enabled = false;
            }

            else
                txtMusBilgileri.Text = aranacakMusNo + " numarasına sahip herhangi bir müşteri bulunamadı.";
        }

        private void MusteriBilgileriniYazdir()
        {
            txtMusBilgileri.Text = "TCKN: " + ilgiliMusteri.TCKN + Environment.NewLine +
                                   "Ad Soyad: " + ilgiliMusteri.ad + " " + ilgiliMusteri.soyad + Environment.NewLine +
                                   "Müşteri Türü: " + ilgiliMusteri.musteriTuru;
        }
      
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if (ilgiliMusteri.musteriTuru == "Bireysel Müşteri")
            {
                hesapNo = Convert.ToUInt64(randHesapNo.Next(1000000, 5000000)); // Bireysel hesaba ait random hesap numarası üretme 1000000 - 5000000
                FarkliHesapNumarasiUret(1000000, 5000000);
                HesapBilgileriniKaydet();
            } 

            else if(ilgiliMusteri.musteriTuru == "Ticari Müşteri")
            {
                hesapNo = Convert.ToUInt64(randHesapNo.Next(5000000, 10000000)); // Ticari hesaba ait random hesap numarası üretme 5000000 - 10000000
                FarkliHesapNumarasiUret(5000000, 10000000);
                HesapBilgileriniKaydet();
            }

            else
            {
                // hatalı
            }

            islemTarihi = DateTime.Now;
            hesapOzeti = new HesapOzeti(yeniHesap, "Hesap Açma", 100, islemTarihi,rapor);
            yeniHesap.HesapOzetiEkle(hesapOzeti);

            btnHesapAc.Hide();
            lblHesapNo.Show();
            lblHesapNo.Text = hesapNo.ToString();
        }

        private void HesapBilgileriniKaydet()
        {
            yeniHesap = new Hesap();
            yeniHesap.hesapNumarasi = hesapNo;
            yeniHesap.ekHesap = 100;
            yeniHesap.hangiMusteriyeAit = ilgiliMusteri;
            ilgiliMusteri.MusteriyeHesapEkle(yeniHesap);
            banka.BankayaHesapEkle(yeniHesap);
        }

        /// <summary>
        /// Bankaya kayıtlı hesap numarası olması durumunda hesap numarasının tekrar üretilmesi
        /// </summary>
        /// <param name="minDeger">Random alt değer</param>
        /// <param name="maxDeger">Random üst değer</param>
        private void FarkliHesapNumarasiUret(int minDeger, int maxDeger)
        {
            foreach (Hesap mevcutHesaplar in banka.Hesaplar)
            {
                while (hesapNo == mevcutHesaplar.hesapNumarasi)
                {
                    hesapNo = Convert.ToUInt64(randHesapNo.Next(minDeger, maxDeger));
                    FarkliHesapNumarasiUret(minDeger, maxDeger);
                }
            }
        }

        private void lblHesapNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
