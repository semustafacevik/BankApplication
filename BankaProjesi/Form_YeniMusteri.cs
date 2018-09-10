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
    public partial class frmYeniMusteri : Form
    {
        public Banka banka;
        public frmYeniMusteri()
        {
            InitializeComponent();
            btnMusteriNumarasi.Hide();
        }

        ulong musteriNo = 0;
        Random randMusteriNo = new Random();


        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            ulong musteriTCKN = Convert.ToUInt64(txtTCKN.Text);
            string musteriAdi = txtAd.Text;
            string musteriSoyadi = txtSoyad.Text;
            ulong musteriTelno = Convert.ToUInt64(txtTelNo.Text);
            string musteriTuru = cmbMusTur.SelectedItem.ToString();

            if (musteriTuru == "Bireysel Müşteri")
            {
                musteriNo = Convert.ToUInt32(randMusteriNo.Next(100000, 500000));
                FarkliMusteriNumarasiUretme(100000, 500000);
            }

            else if (musteriTuru == "Ticari Müşteri")
            {
                musteriNo = Convert.ToUInt32(randMusteriNo.Next(500000, 1000000));
                FarkliMusteriNumarasiUretme(500000, 1000000);
            }

            else
            {
                // hatalı
            }

            btnMusteriNumarasi.Text = musteriNo.ToString();
            btnMusteriEkle.Hide();
            btnMusteriNumarasi.Show();

            MusteriBilgileriniKaydet(musteriTCKN, musteriAdi, musteriSoyadi, musteriTelno, musteriTuru, musteriNo);
        }

        private void FarkliMusteriNumarasiUretme(int minDeger, int maxDeger)
        {
            foreach (Musteri mevcutMusteriler in banka.Musteriler)
            {
                while (musteriNo == mevcutMusteriler.musteriNosu)
                {
                    musteriNo = Convert.ToUInt32(randMusteriNo.Next(minDeger, maxDeger));
                    FarkliMusteriNumarasiUretme(minDeger, maxDeger);
                }
            }
        }

        private void MusteriEklemeFormunuKapatma(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriBilgileriniKaydet(ulong musTCKN, string musAd, string musSoyad, ulong musTelno, string musTur, ulong musNo)
        {
            Musteri yeniMusteri = new Musteri
            {
                TCKN = musTCKN,
                ad = musAd,
                soyad = musSoyad,
                telNo = musTelno,
                musteriTuru = musTur,
                musteriNosu = musNo
            };
            banka.BankayaMusteriEkle(yeniMusteri);
        }

    }
}
