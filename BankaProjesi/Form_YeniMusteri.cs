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

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            ulong musteriTCNo = Convert.ToUInt32(txtTCNo.Text);
            string musteriAdi = txtAd.Text;
            string musteriSoyadi = txtSoyad.Text;
            ulong musteriTelno = Convert.ToUInt32(txtTelNo.Text);
            string musteriTuru = cmbMusTur.SelectedItem.ToString();

            ulong musteriNo = 0;
            Random randMusteriNo = new Random();

            if (musteriTuru == "Bireysel Müşteri")
            {
                musteriNo = Convert.ToUInt32(randMusteriNo.Next(100000, 500000));
            }

            else if (musteriTuru == "Ticari Müşteri")
            {
                musteriNo = Convert.ToUInt32(randMusteriNo.Next(500000, 1000000));
            }

            else
            {
                //// hatalı
            }

            btnMusteriNumarasi.Text = musteriNo.ToString();
            btnMusteriEkle.Hide();
            btnMusteriNumarasi.Show();
            
            
            MusteriBilgileriniKaydet(musteriTCNo, musteriAdi, musteriSoyadi, musteriTelno, musteriTuru, musteriNo);

        }

        private void MusteriEklemeFormunuKapatma(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriBilgileriniKaydet(ulong musTCNo, string musAd, string musSoyad, ulong musTelno, string musTur, ulong musNo)
        {
            Musteri yeniMusteri = new Musteri
            {
                TCNo = musTCNo,
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
