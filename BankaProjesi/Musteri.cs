using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Musteri
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

    }
}
