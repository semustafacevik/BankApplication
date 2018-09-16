using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Musteri_Bireysel : Musteri
    {
        HesapOzeti hesapOzeti_Gond;
        HesapOzeti hesapOzeti_Alan;
        DateTime islemTarihi;
        GelirGiderRaporu rapor = null;

        public override bool ParaHavale(Hesap gonderenHesap, Hesap alacakHesap, decimal gonderilecekMiktar)
        {
            decimal tempGondMiktar = gonderilecekMiktar;
            decimal havaleUcreti = gonderilecekMiktar * 0.02m;
            gonderilecekMiktar = tempGondMiktar + havaleUcreti;

            bool havaleOnay = base.ParaHavale(gonderenHesap, alacakHesap, gonderilecekMiktar);

            if (havaleOnay)
            {
                islemTarihi = DateTime.Now;
                hesapOzeti_Gond = new HesapOzeti(gonderenHesap, "Havale >> (" + alacakHesap.hesapNumarasi + ")", -tempGondMiktar, islemTarihi, rapor);
                gonderenHesap.HesapOzetiEkle(hesapOzeti_Gond);

                hesapOzeti_Gond = new HesapOzeti(gonderenHesap, "Havale Ücreti", -havaleUcreti, islemTarihi,rapor);
                gonderenHesap.HesapOzetiEkle(hesapOzeti_Gond);

                alacakHesap.hangiMusteriyeait.HesabaParaYatir(alacakHesap, tempGondMiktar);
                islemTarihi = DateTime.Now;
                hesapOzeti_Alan = new HesapOzeti(alacakHesap, "(" + gonderenHesap.hesapNumarasi + ") >> Havale", tempGondMiktar, islemTarihi, rapor);
                alacakHesap.HesapOzetiEkle(hesapOzeti_Alan);
            }

            return havaleOnay;
        }
    }
}
