using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public abstract class Musteri
    {
        public ulong TCKN;
        public string ad;
        public string soyad;
        public ulong telNo;
        public string musteriTuru;
        public ulong musteriNosu;

        public List<Hesap> MusterininHesaplari;

        public Musteri()
        {
            MusterininHesaplari = new List<Hesap>();
        }

        public void MusteriyeHesapEkle(Hesap yeniHesap)
        {
            MusterininHesaplari.Add(yeniHesap);
        }


        int gelenOnaykodu = 0;

        public int HesabaParaYatir(Hesap ilgiliHesap, decimal yatirilacakMiktar)
        {
            gelenOnaykodu = ParaYatirmaKontrol(ilgiliHesap, yatirilacakMiktar);

            switch (gelenOnaykodu)
            {
                case 10:
                    ilgiliHesap.bakiye = yatirilacakMiktar - ilgiliHesap.ekHesap;
                    ilgiliHesap.ekHesap = 100;
                    return gelenOnaykodu;

                case 11:                   
                    ilgiliHesap.bakiye = (ilgiliHesap.ekHesap + yatirilacakMiktar) - 100;
                    ilgiliHesap.ekHesap = 100;
                    return gelenOnaykodu;

                case 12:
                    ilgiliHesap.ekHesap += yatirilacakMiktar;
                    return gelenOnaykodu;

                case 13:
                    ilgiliHesap.bakiye += yatirilacakMiktar;
                    return gelenOnaykodu;

                default:
                    return 0;
            }
        }

        public int HesaptanParaCek(Hesap ilgiliHesap, decimal cekilecekMiktar)
        {
            gelenOnaykodu = ParaCekmeKontrol(ilgiliHesap,cekilecekMiktar);

            switch (gelenOnaykodu)
            {
                case 20:
                    return gelenOnaykodu;

                case 21:
                    return gelenOnaykodu;

                case 22:
                    ilgiliHesap.bakiye -= cekilecekMiktar;
                    ilgiliHesap.ekHesap += ilgiliHesap.bakiye;
                    ilgiliHesap.bakiye = 0;
                    ilgiliHesap.hesaptanCekilentoplamTutar += cekilecekMiktar;
                    return gelenOnaykodu;

                case 23:
                    ilgiliHesap.bakiye -= cekilecekMiktar;
                    ilgiliHesap.hesaptanCekilentoplamTutar += cekilecekMiktar;
                    return gelenOnaykodu;

                default:
                    return 0;
            }
        }

        public int ParaYatirmaKontrol(Hesap kontrolEdilecekhesap, decimal yatirilacakMiktar)
        {
            if (kontrolEdilecekhesap.ekHesap < 100) // ek hesaptaki miktar 100 degilse ilk once o tamamlanmali
            {
                if (yatirilacakMiktar > 100)
                    return 10;  // yatirilacak miktar 100' den fazlaysa 

                else if (kontrolEdilecekhesap.ekHesap + yatirilacakMiktar > 100)
                    return 11;

                else
                    return 12; // yatiralacak miktar 100' den azsa
            }

            else // ek hesaptaki miktar 100 ise
                return 13;
        }

        public int ParaCekmeKontrol(Hesap kontrolEdilecekhesap, decimal cekilecekMiktar)
        {
            if ((cekilecekMiktar + kontrolEdilecekhesap.hesaptanCekilentoplamTutar) > 750)
            {
                return 20; // gunluk para cekme limiti asildi
            }

            else if (cekilecekMiktar > (kontrolEdilecekhesap.bakiye + kontrolEdilecekhesap.ekHesap))
            {
                return 21; // yetersiz bakiye
            }

            else if (cekilecekMiktar > kontrolEdilecekhesap.bakiye && cekilecekMiktar < (kontrolEdilecekhesap.bakiye + kontrolEdilecekhesap.ekHesap))
            {
                return 22; // yetersiz bakiye ama ek hesapla birlikte yeterli miktar var
            }

            else
                return 23;  // herhangi bir sorun yok
        }


        public virtual bool ParaHavale(Hesap gonderenHesap, Hesap alacakHesap, decimal gonderilecekMiktar)
        {
            if (gonderenHesap.bakiye >= gonderilecekMiktar)
            {
                gonderenHesap.bakiye -= gonderilecekMiktar;
                return true;
            }

            else
                return false;
        }

    }
}
