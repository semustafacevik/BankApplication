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
        public Hesap hesap;
        public string islemTuru;
        public decimal tutar;
        public DateTime islemTarihi;

        public HesapOzeti(Hesap hesap, string islemTuru, decimal tutar, DateTime islemTarihi, GelirGiderRaporu rapor)
        {
            this.hesap = hesap;
            this.islemTuru = islemTuru;
            this.tutar = tutar;
            this.islemTarihi = islemTarihi;

            switch (islemTuru)
            {
                case "Hesap Açma":
                    rapor.RaporEt(tutar, "girenpara");
                    break;

                case "Para Yatırma":
                    rapor.RaporEt(tutar, "girenpara");
                    break;

                case "Para Çekme":
                    rapor.RaporEt(tutar, "cikanpara");
                    break;

                default:
                    break;
            }
        }
    }
}
