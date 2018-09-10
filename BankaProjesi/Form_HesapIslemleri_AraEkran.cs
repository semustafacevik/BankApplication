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
    public partial class frmHesapIslemleri : Form
    {
        public Banka banka;

        public frmHesapIslemleri()
        {
            InitializeComponent();
            btnHesKapat.Enabled = false;
            btnParaYatir.Enabled = false;
            btnParaCek.Enabled = false;
            btnHavale.Enabled = false;

            lblGonhesNo.Hide();
            txtGondHesNo.Hide();

        }

        private void frmHesapIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void btnParayatir_Click(object sender, EventArgs e)
        {
            this.Size = new Size(600, 350);
        }

        private ulong bulunacakHesap = 0;

        private void btnHesBul_Click(object sender, EventArgs e)
        {
            bulunacakHesap = Convert.ToUInt64(txtHesapNo.Text);

            foreach (Hesap mevcutHesaplar in banka.Hesaplar)
            {
                if(bulunacakHesap == mevcutHesaplar.hesapNumarasi)
                {
                    txtHesBilgileri.Text = mevcutHesaplar.hangiMusteriyeait.TCKN + "   " + mevcutHesaplar.bakiye;
                    break;
                }
            }
        }
    }
}
