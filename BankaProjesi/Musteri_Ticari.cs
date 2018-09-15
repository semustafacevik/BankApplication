using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Musteri_Ticari : Musteri
    {
        HesapOzeti hesapOzeti;
        DateTime islemTarihi;

        public override bool ParaHavale(Hesap gonderenHesap, Hesap alacakHesap, decimal gonderilecekMiktar)
        {
            bool gelenOnay = base.ParaHavale(gonderenHesap, alacakHesap, gonderilecekMiktar);

            if (gelenOnay)
            {
                islemTarihi = DateTime.Now;
                hesapOzeti = new HesapOzeti(gonderenHesap, "Havale(" + alacakHesap.hesapNumarasi + ")", gonderilecekMiktar, islemTarihi);
                gonderenHesap.HesapOzetiEkle(hesapOzeti);
                alacakHesap.hangiMusteriyeait.HesabaParaYatir(alacakHesap, gonderilecekMiktar);
            }

            return gelenOnay;
        }
    }
}
