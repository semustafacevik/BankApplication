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
            lblMusteriNo.Hide();
        }

        ulong musteriTCKN;
        string musteriAdi;
        string musteriSoyadi;
        ulong musteriTelno;
        string musteriTuru;
        ulong musteriNo;
        Random randMusteriNo = new Random();

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            musteriTCKN = Convert.ToUInt64(txtTCKN.Text);
            musteriAdi = txtAd.Text;
            musteriSoyadi = txtSoyad.Text;
            musteriTelno = Convert.ToUInt64(txtTelNo.Text);
            musteriTuru = cmbMusTur.SelectedItem.ToString();

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

            lblMusteriNo.Text = musteriNo.ToString();
            btnMusteriEkle.Hide();
            lblMusteriNo.Show();

            MusteriBilgileriniKaydetme();
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

        private void MusteriBilgileriniKaydetme()
        {
            switch (musteriTuru)
            {
                case "Bireysel Müşteri":
                    Musteri_Bireysel yeniBirMusteri = new Musteri_Bireysel
                    {
                        TCKN = musteriTCKN,
                        ad = musteriAdi,
                        soyad = musteriSoyadi,
                        telNo = musteriTelno,
                        musteriTuru = musteriTuru,
                        musteriNosu = musteriNo
                    };
                    banka.BankayaMusteriEkle(yeniBirMusteri);
                    break;

                case "Ticari Müşteri":
                    Musteri_Ticari yeniTicMusteri = new Musteri_Ticari
                    {
                        TCKN = musteriTCKN,
                        ad = musteriAdi,
                        soyad = musteriSoyadi,
                        telNo = musteriTelno,
                        musteriTuru = musteriTuru,
                        musteriNosu = musteriNo
                    };
                    banka.BankayaMusteriEkle(yeniTicMusteri);
                    break;

                default:
                    // hatalı
                    break;
            }
        }

        private void lblMusteriNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
