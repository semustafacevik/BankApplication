using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Musteri_Bireysel : Musteri
    {
        HesapOzeti hesapOzeti;
        DateTime islemTarihi;

        public override bool ParaHavale(Hesap gonderenHesap, Hesap alacakHesap, decimal gonderilecekMiktar)
        {
            decimal tempGondMiktar = gonderilecekMiktar;
            gonderilecekMiktar += gonderilecekMiktar * 0.02m;

            bool gelenOnay = base.ParaHavale(gonderenHesap, alacakHesap, gonderilecekMiktar);

            if (gelenOnay)
            {
                islemTarihi = DateTime.Now;
                hesapOzeti = new HesapOzeti(gonderenHesap, "Havale(" + alacakHesap.hesapNumarasi + ")", tempGondMiktar, islemTarihi);
                gonderenHesap.HesapOzetiEkle(hesapOzeti);
                alacakHesap.hangiMusteriyeait.HesabaParaYatir(alacakHesap, tempGondMiktar);
            }

            return gelenOnay;
        }
    }
}
