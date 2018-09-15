using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaProjesi
{
    public class HesapOzeti
    {
        public Hesap ilgiliHesap;
        public string islemTuru;
        public decimal tutar;
        public DateTime islemTarihi;

        public HesapOzeti()
        {
        }

        public HesapOzeti(Hesap hesap, string islemTur, decimal miktar, DateTime tarih)
        {
            ilgiliHesap = hesap;
            islemTuru = islemTur;
            tutar = miktar;
            islemTarihi = tarih;
        }
    }
}
