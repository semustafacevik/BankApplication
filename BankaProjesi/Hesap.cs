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
        public decimal hesaptanCekilentoplamTutar;
        public Musteri hangiMusteriyeait;


        private int gelenOnaykodu = 0;

        public int HesabaParaYatir(decimal yatirilacakMiktar)
        {
            gelenOnaykodu = ParaYatirmaKontrol(yatirilacakMiktar);

            switch (gelenOnaykodu)
            {
                case 10:
                    bakiye = yatirilacakMiktar - ekHesap;
                    ekHesap = 100;
                    return gelenOnaykodu;

                case 11:
                    ekHesap += yatirilacakMiktar;
                    return gelenOnaykodu;

                case 12:
                    bakiye += yatirilacakMiktar;
                    return gelenOnaykodu;

                default:
                    return 0;
            }
        }

        public int HesaptanParaCek(decimal cekilecekMiktar)
        {
            gelenOnaykodu = ParaCekmeKontrol(cekilecekMiktar);

            switch (gelenOnaykodu)
            {
                case 20:
                    return gelenOnaykodu;

                case 21:
                    return gelenOnaykodu;

                case 22:
                    bakiye -= cekilecekMiktar;
                    ekHesap += bakiye;
                    bakiye = 0;
                    hesaptanCekilentoplamTutar += cekilecekMiktar;
                    return gelenOnaykodu;

                case 23:
                    bakiye -= cekilecekMiktar;
                    hesaptanCekilentoplamTutar += cekilecekMiktar;
                    return gelenOnaykodu;

                default:
                    return 0;
            }
        }

        public int ParaYatirmaKontrol(decimal yatirilacakMiktar)
        {
            if (ekHesap != 100) // ek hesaptaki miktar 100 degilse ilk once o tamamlanmali
            {
                if (yatirilacakMiktar > 100)
                    return 10;  // yatirilacak miktar 100' den fazlaysa 

                else
                    return 11; // yatiralacak miktar 100' den azsa
            }

            else // ek hesaptaki miktar 100 ise
                return 12;
        }

        public int ParaCekmeKontrol(decimal cekilecekMiktar)
        {
            if ((cekilecekMiktar + hesaptanCekilentoplamTutar) > 750)
            {
                return 20; // gunluk para cekme limiti asildi
            }

            else if (cekilecekMiktar > (bakiye + ekHesap))
            {
                return 21; // yetersiz bakiye
            }

            else if (cekilecekMiktar > bakiye && cekilecekMiktar < (bakiye + ekHesap))
            {
                return 22; // yetersiz bakiye ama ek hesapla birlikte yeterli miktar var
            }

            else
                return 23;  // herhangi bir sorun yok
        }
    }
}
