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
    public partial class frmParaYatirmaCekme : Form
    {
        private Hesap hesap;
        private Musteri ilgiliMusteri;
        private string islemTuru;

        public frmParaYatirmaCekme(Hesap hesap, string islemTuru)
        {
            InitializeComponent();
            this.hesap = hesap;
            this.islemTuru = islemTuru;
            ilgiliMusteri = hesap.hangiMusteriyeait;
        }

        decimal girilenTutar = 0;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            girilenTutar = Convert.ToDecimal(txtTutar.Text);

            txtDurumBilgisi.Text = "TCKN: " + hesap.hangiMusteriyeait.TCKN + Environment.NewLine +
                                   "Ad Soyad: " + hesap.hangiMusteriyeait.ad + " " + hesap.hangiMusteriyeait.soyad + Environment.NewLine +
                                   "Hesap No: " + hesap.hesapNumarasi + Environment.NewLine;
            int mesajKodu = 0;
            switch (islemTuru)
            {
                case "parayatirma":
                    mesajKodu = ilgiliMusteri.HesabaParaYatir(hesap,girilenTutar);
                    break;

                case "paracekme":
                    mesajKodu = ilgiliMusteri.HesaptanParaCek(hesap,girilenTutar);
                    break;

                default:
                    break;
            }

            MesajKodunaGoreBilgilendirme(mesajKodu);
            txtDurumBilgisi.Text += " Toplam bakiye: " + Environment.NewLine +
                                    ">>> " + hesap.bakiye + " ₺ (Ek hesaptaki tutar: " + hesap.ekHesap + " ₺)";

            btnOnayla.Enabled = false;
            this.Size = new Size(400, 390);
        }            

        private void MesajKodunaGoreBilgilendirme(int gelenMesajKodu)
        {
            switch (gelenMesajKodu)
            {
                case 10 | 11:
                    txtDurumBilgisi.Text += "Ek hesaptaki miktar tam olmadığı için yatırılan parayla ilk ek hesap tamamlandı, arta kalan para da bakiyeye aktarıldı.";
                    break;

                case 12:
                    txtDurumBilgisi.Text += "Ek hesaptaki miktar tam olmadığı için yatırılan para ek hesaba yatırıldı.";
                    break;

                case 13:
                    txtDurumBilgisi.Text += "Para yatırma işleminiz gerçekleşti.";
                    break;

                case 20:
                    txtDurumBilgisi.Text += "Günlük para çekme limitiniz 750 ₺'dir. İşlem gerçekleştirelemedi. ";
                    break;

                case 21:
                    txtDurumBilgisi.Text += "Yetersiz bakiye. İşlem gerçekleştirelemedi.";
                    break;

                case 22:
                    txtDurumBilgisi.Text += "Çekmek istediğiniz tutar bakiyenizden fazla olduğu için ek hesaptan borç alınıyor.";
                    break;

                case 23:
                    txtDurumBilgisi.Text += "Para çekme işleminiz gerçekleşti.";
                    break;

                default:
                    break;
            }
        }
    }
}
