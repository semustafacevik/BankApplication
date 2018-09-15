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
    public partial class frmHesapOzeti : Form
    {
        public Banka banka;
        Hesap ilgiliHesap;
        Hesap temp;

        public frmHesapOzeti(Hesap hesap)
        {
            InitializeComponent();
            temp = hesap;
        }

        private void txtHesOzet_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHesapOzeti_Load(object sender, EventArgs e)
        {
            ilgiliHesap = banka.HesapBul(temp.hesapNumarasi);

            txtHesOzet.Text += ilgiliHesap.HesapOzetiYazdir(ilgiliHesap);
        }
    }
}
