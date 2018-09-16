using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Musteri_Ticari : Musteri
    {
        HesapOzeti hesapOzeti_Gond;
        HesapOzeti hesapOzeti_Alan;
        DateTime islemTarihi;

        public override bool ParaHavale(Hesap gonderenHesap, Hesap alacakHesap, decimal gonderilecekMiktar)
        {
            bool havaleOnay = base.ParaHavale(gonderenHesap, alacakHesap, gonderilecekMiktar);

            if (havaleOnay)
            {
                islemTarihi = DateTime.Now;
                hesapOzeti_Gond = new HesapOzeti(gonderenHesap, "Havale >> (" + alacakHesap.hesapNumarasi + ")", -gonderilecekMiktar, islemTarihi);
                gonderenHesap.HesapOzetiEkle(hesapOzeti_Gond);

                alacakHesap.hangiMusteriyeait.HesabaParaYatir(alacakHesap, gonderilecekMiktar);
                islemTarihi = DateTime.Now;
                hesapOzeti_Alan = new HesapOzeti(alacakHesap, "(" + gonderenHesap.hesapNumarasi + ") >> Havale", gonderilecekMiktar, islemTarihi);
                alacakHesap.HesapOzetiEkle(hesapOzeti_Alan);
            }
            return havaleOnay;
        }
    }
}
