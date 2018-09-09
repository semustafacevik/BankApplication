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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmYeniMusteri yeniMusteri = new frmYeniMusteri();
            yeniMusteri.Show();

        }
    }
}
