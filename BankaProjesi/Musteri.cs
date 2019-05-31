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
        public ulong telefonNumarasi;
        public string musteriTuru;
        public ulong musteriNumarasi;
        public List<Hesap> MusterininHesaplari;

        public Musteri()
        {
            MusterininHesaplari = new List<Hesap>();
        }

        public void MusteriyeHesapEkle(Hesap yeniHesap)
        {
            MusterininHesaplari.Add(yeniHesap);
        }

        public void MusteridenHesapSil(Hesap silinecekHesap)
        {
            MusterininHesaplari.Remove(silinecekHesap);
        }

        int gelenOnaykodu;
        public int HesabaParaYatir(Hesap ilgiliHesap, decimal yatirilacakMiktar)
        {
            gelenOnaykodu = ParaYatirmaKontrol(ilgiliHesap, yatirilacakMiktar); // ilgili fonksiyondan onay kodunun çekilmesi

            switch (gelenOnaykodu) // gelen onay koduna göre işlemlerin yapılması
            {
                case 10:
                    ilgiliHesap.bakiye = yatirilacakMiktar - (100 - ilgiliHesap.ekHesap);
                    ilgiliHesap.ekHesap = 100;
                    break;

                case 11:                   
                    ilgiliHesap.bakiye = (ilgiliHesap.ekHesap + yatirilacakMiktar) - 100;
                    ilgiliHesap.ekHesap = 100;
                    break;

                case 12:
                    ilgiliHesap.ekHesap += yatirilacakMiktar;
                    break;

                case 13:
                    ilgiliHesap.bakiye += yatirilacakMiktar;
                    break;

                default:
                    gelenOnaykodu = 0;
                    break;
            }

            return gelenOnaykodu;
        }

        public int HesaptanParaCek(Hesap ilgiliHesap, decimal cekilecekMiktar)
        {
            gelenOnaykodu = ParaCekmeKontrol(ilgiliHesap,cekilecekMiktar); // ilgili fonksiyondan onay kodunun çekilmesi

            switch (gelenOnaykodu) // gelen onay koduna göre işlemlerin yapılması
            {
                case 20:
                    break;

                case 21:
                    break;

                case 22:
                    ilgiliHesap.bakiye -= cekilecekMiktar;
                    ilgiliHesap.ekHesap += ilgiliHesap.bakiye;
                    ilgiliHesap.bakiye = 0;
                    ilgiliHesap.hesaptanCekilenToplamTutar += cekilecekMiktar;
                    break;

                case 23:
                    ilgiliHesap.bakiye -= cekilecekMiktar;
                    ilgiliHesap.hesaptanCekilenToplamTutar += cekilecekMiktar;
                    break;

                default:
                    gelenOnaykodu = 0;
                    break;
            }

            return gelenOnaykodu;
        }

        /// <summary>
        /// Para yatırma işlemine ait kontrollerin yapıldığı fonksiyon
        /// </summary>
        /// <param name="kontrolEdilecekhesap">Para yatırılacak ilgili hesap</param>
        /// <param name="yatirilacakMiktar">İlgili hesaba yatırılacak tutar</param>
        /// <returns>Kontrollere göre onay kodu 10 - 13</returns>
        public int ParaYatirmaKontrol(Hesap kontrolEdilecekhesap, decimal yatirilacakMiktar) 
        {
            if (kontrolEdilecekhesap.ekHesap < 100) // ilgili hesabın ilk önce ek hesaptaki tutarı kontrol edilir -> ekhesap 100 tlden az ise önce ek hesap tamamlanacağına dair onay kodları
            {
                if (yatirilacakMiktar > 100)
                    return 10; 

                else if (kontrolEdilecekhesap.ekHesap + yatirilacakMiktar > 100)
                    return 11;

                else
                    return 12;
            }

            else // ek hesap 100 tlden fazlaysa yatırılan para direk hesaba aktarılacağına dair onay kodu
                return 13;
        }

        /// <summary>
        ///  Para çekme işlemine ait kontrollerin yapıldığı fonksiyon
        /// </summary>
        /// <param name="kontrolEdilecekhesap">Para çekilecek ilgili hesap</param>
        /// <param name="cekilecekMiktar">İlgili hesaptan çekilecek tutar</param>
        /// <returns>Kontrollere göre onay kodu 20 - 23</returns>
        public int ParaCekmeKontrol(Hesap kontrolEdilecekhesap, decimal cekilecekMiktar) 
        {
            if ((cekilecekMiktar + kontrolEdilecekhesap.hesaptanCekilenToplamTutar) > 750)
            {
                return 20; // gunluk para cekme limiti asildiğina dair onay kodu
            }

            else if (cekilecekMiktar > (kontrolEdilecekhesap.bakiye + kontrolEdilecekhesap.ekHesap))
            {
                return 21; // yetersiz bakiye olduğuna dair onay kodu
            }

            else if (cekilecekMiktar > kontrolEdilecekhesap.bakiye && cekilecekMiktar <= (kontrolEdilecekhesap.bakiye + kontrolEdilecekhesap.ekHesap))
            {
                return 22; // yetersiz bakiye ama ek hesapla birlikte yeterli miktar olduğuna dair onay kodu
            }

            else
                return 23;  // herhangi bir sorun olmadığına dair onay kodu
        }

        /// <summary>
        /// Para havale etme işlemine ait kontrollerin yapıldığı sanal fonksiyon - bu sınıftan kalıtılan sınıflarda bu sanal fonksiyon ezielecek -
        /// </summary>
        /// <param name="gonderenHesap">İlgili gönderen hesap</param>
        /// <param name="alacakHesap">İlgili alacak hesap</param>
        /// <param name="gonderilecekMiktar">Havale işlemine ait ilgili miktar</param>
        /// <returns>Kontroller sonucunda true or false</returns>
        public virtual bool ParaHavale(Hesap gonderenHesap, Hesap alacakHesap, decimal gonderilecekMiktar)
        {
            if (gonderilecekMiktar <= gonderenHesap.bakiye)
            {
                gonderenHesap.bakiye -= gonderilecekMiktar;
                return true;
            }

            else
                return false;
        }

    }
}
