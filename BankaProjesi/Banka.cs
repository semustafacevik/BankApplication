using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Banka
    {
        public List<Musteri> Musteriler;
        public List<Hesap> Hesaplar;

        public Banka()
        {
            Musteriler = new List<Musteri>();
            Hesaplar = new List<Hesap>();
        }

        public void BankayaMusteriEkle(Musteri yenimusteri)
        {
            Musteriler.Add(yenimusteri);
        }

        public void BankayaHesapEkle(Hesap yeniHesap)
        {
            Hesaplar.Add(yeniHesap);
        }

        public void BankadanHesapSil(Hesap silinecekHesap)
        {
            Hesaplar.Remove(silinecekHesap);
        }

        public Musteri MusteriBul(ulong musteriNumarasi)
        {
            Musteri arananMusteri;

            foreach (Musteri musteriler in Musteriler)
            {
                if (musteriler.musteriNumarasi == musteriNumarasi)
                {
                    arananMusteri = musteriler;
                    return arananMusteri;
                }
            }
            return null;
        }

        public Hesap HesapBul(ulong hesapNumarasi)
        {
            Hesap arananHesap = null;

            foreach (Hesap hesaplar in Hesaplar)
            {
                if (hesaplar.hesapNumarasi == hesapNumarasi) 
                {
                    arananHesap = hesaplar;
                    return arananHesap;
                }
            }
            return null;
        }

        /// <summary>
        /// Bankada ilgili TC Kimlik Numarasına ait müşteri olup olmadığını sorgulayan fonksiyon
        /// </summary>
        /// <param name="TCKN">İlgili TC Kimlik Numarası</param>
        /// <returns>İlgili TCKN ait /müşteri yoksa -> true /müşteri varsa -> false </returns>
        public bool KimlikSorgula(ulong TCKN)
        {
            foreach (Musteri musteriler in Musteriler) // Bankadaki tüm müşterilerin taranması
            {
                if (musteriler.TCKN == TCKN)
                    return false;
            }

            return true;
        }
    }
}
