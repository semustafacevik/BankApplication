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
        public GelirGiderRaporu rapor;
        Hesap hesap;
        Musteri ilgiliMusteri;
        string islemTuru;

        public frmParaYatirmaCekme(Hesap hesap, string islemTuru)
        {
            InitializeComponent();
            this.hesap = hesap;
            this.islemTuru = islemTuru;
            ilgiliMusteri = hesap.hangiMusteriyeAit;
        }      

        decimal girilenTutar;
        HesapOzeti hesapOzeti;
        DateTime islemTarihi;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            girilenTutar = Convert.ToDecimal(txtTutar.Text);

            txtDurumBil.Text = "Hesap No: " + hesap.hesapNumarasi + Environment.NewLine;

            int mesajKodu = 0;
            switch (islemTuru)
            {
                case "parayatirma":
                    mesajKodu = ilgiliMusteri.HesabaParaYatir(hesap,girilenTutar);
                    islemTarihi = DateTime.Now;
                    hesapOzeti = new HesapOzeti(hesap, "Para Yatırma", girilenTutar, islemTarihi,rapor);
                    hesap.HesapOzetiEkle(hesapOzeti);
                    break;

                case "paracekme":
                    mesajKodu = ilgiliMusteri.HesaptanParaCek(hesap,girilenTutar);
                    if (mesajKodu == 22 || mesajKodu == 23)
                    {
                        islemTarihi = DateTime.Now;
                        hesapOzeti = new HesapOzeti(hesap, "Para Çekme", -girilenTutar, islemTarihi,rapor);
                        hesap.HesapOzetiEkle(hesapOzeti);
                    }
                    break;

                default:
                    break;
            }

            MesajKodunaGoreBilgilendir(mesajKodu);
            txtDurumBil.Text += " Toplam bakiye: " + Environment.NewLine +
                                    ">>> " + hesap.bakiye + " ₺ (Ek hesaptaki tutar: " + hesap.ekHesap + " ₺)";
            btnOnayla.Enabled = false;
        }            

        private void MesajKodunaGoreBilgilendir(int gelenMesajKodu)
        {
            switch (gelenMesajKodu)
            {
                case 10:
                    txtDurumBil.Text += "Ek hesaptaki miktar tam olmadığı için yatırılan parayla ilk ek hesap tamamlandı, arta kalan para da bakiyeye aktarıldı.";
                    break;

                case 11:
                    txtDurumBil.Text += "Ek hesaptaki miktar tam olmadığı için yatırılan parayla ilk ek hesap tamamlandı, arta kalan para da bakiyeye aktarıldı.";
                    break;

                case 12:
                    txtDurumBil.Text += "Ek hesaptaki miktar tam olmadığı için yatırılan para ek hesaba yatırıldı.";
                    break;

                case 13:
                    txtDurumBil.Text += "Para yatırma işleminiz gerçekleşti.";
                    break;

                case 20:
                    txtDurumBil.Text += "Günlük para çekme limitiniz 750 ₺'dir. İşlem gerçekleştirelemedi. ";
                    break;

                case 21:
                    txtDurumBil.Text += "Yetersiz bakiye. İşlem gerçekleştirelemedi.";
                    break;

                case 22:
                    txtDurumBil.Text += "Çekmek istediğiniz tutar bakiyenizden fazla olduğu için ek hesaptan borç alınıyor.";
                    break;

                case 23:
                    txtDurumBil.Text += "Para çekme işleminiz gerçekleşti.";
                    break;

                default:
                    break;
            }
        }
    }
}
