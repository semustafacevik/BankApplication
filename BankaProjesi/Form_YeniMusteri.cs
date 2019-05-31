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
            ButonAktivasyon_Gizle();
        }
        
        ulong musteriTCKN;
        string musteriAd;
        string musteriSoyad;
        ulong musteriTelno;
        string musteriTur;
        ulong musteriNo;
        Random randMusterino = new Random(); 

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            ButonAktivasyon_Gizle();
            musteriTCKN = Convert.ToUInt64(txtTCKN.Text);
            musteriAd = txtAd.Text;
            musteriSoyad = txtSoyad.Text;
            musteriTelno = Convert.ToUInt64(txtTelNo.Text);
            musteriTur = cmbMusTur.SelectedItem.ToString();

            bool kayitDurumu = banka.KimlikSorgula(musteriTCKN); // kayıt için onay durumunun alınması

            if (txtTCKN.TextLength == 11 && txtTelNo.TextLength == 10 && kayitDurumu) // TCKN ve TelNo kontrol işlemleri
            {
                if (musteriTur == "Bireysel Müşteri")
                {
                    musteriNo = Convert.ToUInt32(randMusterino.Next(100000, 500000)); // Bireysel müşteriye ait random müşteri numarası üretme 100000 - 500000
                    FarkliMusteriNumarasiUret(100000, 500000);
                }

                else if (musteriTur == "Ticari Müşteri")
                {
                    musteriNo = Convert.ToUInt32(randMusterino.Next(500000, 1000000)); // Ticari müşteriye ait random müşteri numarası üretme 500000 - 1000000
                    FarkliMusteriNumarasiUret(500000, 1000000);
                }

                else
                {
                    // hatalı
                }

                lblMusteriNo.Text = musteriNo.ToString();
                btnMusteriEkle.Hide();
                lblMusteriNo.Show();

                MusteriBilgileriniKaydet();
            }

            else if (!kayitDurumu)
            {
                lblMusteriNo.Text = " Kayıtlı\r\nMüşteri";
                btnMusteriEkle.Hide();
                lblMusteriNo.Show();
            }

            else if (txtTCKN.TextLength != 11 && txtTelNo.TextLength == 10)
                lblUyariTCKN.Show();

            else if (txtTelNo.TextLength != 10 && txtTCKN.TextLength == 11)
                lblUyariTelNo.Show();

            else
            {
                lblUyariTCKN.Show();
                lblUyariTelNo.Show();
            }
        }

        /// <summary>
        /// Bankaya kayıtlı müşteri numarası olması durumunda müşteri numarasının tekrar üretilmesi
        /// </summary>
        /// <param name="minDeger">Random alt değer</param>
        /// <param name="maxDeger">Random üst değer</param>
        private void FarkliMusteriNumarasiUret(int minDeger, int maxDeger)
        {
            foreach (Musteri mevcutMusteriler in banka.Musteriler)
            {
                while (musteriNo == mevcutMusteriler.musteriNumarasi)
                {
                    musteriNo = Convert.ToUInt32(randMusterino.Next(minDeger, maxDeger));
                    FarkliMusteriNumarasiUret(minDeger, maxDeger);
                }
            }
        }

        private void MusteriBilgileriniKaydet()
        {
            switch (musteriTur)
            {
                case "Bireysel Müşteri":
                    Musteri_Bireysel yeniBireyselMus = new Musteri_Bireysel
                    {
                        TCKN = musteriTCKN,
                        ad = musteriAd,
                        soyad = musteriSoyad,
                        telefonNumarasi = musteriTelno,
                        musteriTuru = musteriTur,
                        musteriNumarasi = musteriNo
                    };
                    banka.BankayaMusteriEkle(yeniBireyselMus);
                    break;

                case "Ticari Müşteri":
                    Musteri_Ticari yeniTicariMus = new Musteri_Ticari
                    {
                        TCKN = musteriTCKN,
                        ad = musteriAd,
                        soyad = musteriSoyad,
                        telefonNumarasi = musteriTelno,
                        musteriTuru = musteriTur,
                        musteriNumarasi = musteriNo
                    };
                    banka.BankayaMusteriEkle(yeniTicariMus);
                    break;

                default:
                    // hatalı
                    break;
            }
        }

        private void ButonAktivasyon_Gizle()
        {
            lblUyariTCKN.Hide();
            lblUyariTelNo.Hide();
        }

        private void lblMusteriNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtTelNo_TextChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
