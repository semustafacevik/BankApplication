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
        private string islemTuru;

        public frmParaYatirmaCekme(Hesap hesap, string islemTuru)
        {
            InitializeComponent();
            this.hesap = hesap;
            this.islemTuru = islemTuru;
        }

        decimal girilenTutar = 0;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            girilenTutar = Convert.ToDecimal(txtTutar.Text);

            if (islemTuru == "parayatirma")
            {
                hesap.HesabaParaYatir(girilenTutar);
            }

            else if (islemTuru == "paracekme")
            {
                hesap.HesaptanParaCek(girilenTutar);
            }

            else
            {
                // hatalı
            }


            txtDurumBilgisi.Text = "TCKN: " + hesap.hangiMusteriyeait.TCKN + Environment.NewLine +
                                   "Ad Soyad: " + hesap.hangiMusteriyeait.ad + " " + hesap.hangiMusteriyeait.soyad + Environment.NewLine +
                                   "Hesap No: " + hesap.hesapNumarasi + Environment.NewLine +
                                   "İşlem gerçekleşti. İşlem sonrası toplam bakiye: " + Environment.NewLine +
                                   ">>> " + hesap.bakiye.ToString();

            btnOnayla.Enabled = false;
            this.Size = new Size(400, 340);
        }              
    }
}
