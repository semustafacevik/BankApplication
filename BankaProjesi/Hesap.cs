using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Hesap
    {
        public ulong hesapNumarasi;
        public decimal bakiye;
        public decimal ekHesap;
        public decimal hesaptanCekilenToplamTutar;
        public Musteri hangiMusteriyeAit;
        public List<HesapOzeti> hesapOzeti;

        public Hesap()
        {
            hesapOzeti = new List<HesapOzeti>();
        }

        public void HesapOzetiEkle(HesapOzeti hesapOzeti)
        {
            this.hesapOzeti.Add(hesapOzeti);
        }

        public string HesapOzetiYazdir()
        {
            string yazdirilacakBilgiler = "";

            foreach (HesapOzeti hesOzet in hesapOzeti)
            {
                yazdirilacakBilgiler += hesOzet.islemTuru + "  #  " + hesOzet.tutar + " ₺  #  " + hesOzet.islemTarihi + Environment.NewLine;
            }

            return yazdirilacakBilgiler;
        } 
    }
}
