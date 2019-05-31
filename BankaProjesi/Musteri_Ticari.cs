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
        GelirGiderRaporu rapor = null;

        /// <summary>
        /// Para havale işlemine ait gerekli işlemlerin yapıldığı alt sınıftan ezilen fonksiyon
        /// </summary>
        /// <param name="gonderenHesap">İlgili gönderen hesap</param>
        /// <param name="alacakHesap">İlgili alacak hesap</param>
        /// <param name="gonderilecekMiktar">Havale işlemine ait ilgili miktar</param>
        /// <returns>Havale işlemine ait onay durumu true or false</returns>
        public override bool ParaHavale(Hesap gonderenHesap, Hesap alacakHesap, decimal gonderilecekMiktar)
        {
            bool havaleOnay = base.ParaHavale(gonderenHesap, alacakHesap, gonderilecekMiktar); // havale işlemine ait onayın alınması

            if (havaleOnay) // onay olumluysa yapılacak işlemler
            {
                islemTarihi = DateTime.Now;
                hesapOzeti_Gond = new HesapOzeti(gonderenHesap, "Havale >> (" + alacakHesap.hesapNumarasi + ")", -gonderilecekMiktar, islemTarihi, rapor);
                gonderenHesap.HesapOzetiEkle(hesapOzeti_Gond);

                alacakHesap.hangiMusteriyeAit.HesabaParaYatir(alacakHesap, gonderilecekMiktar);
                islemTarihi = DateTime.Now;
                hesapOzeti_Alan = new HesapOzeti(alacakHesap, "(" + gonderenHesap.hesapNumarasi + ") >> Havale", gonderilecekMiktar, islemTarihi, rapor);
                alacakHesap.HesapOzetiEkle(hesapOzeti_Alan);
            }
            return havaleOnay;
        }
    }
}
