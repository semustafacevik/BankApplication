using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Musteri
    {
        public ulong TCNo;
        public string ad;
        public string soyad;
        public ulong telNo;
        public string musteriTuru;
        public ulong musteriNosu;

        public List<Hesap> hesaplar = new List<Hesap>();

        public void MusteriyeHesapEkle(Hesap yeniHesap)
        {
            hesaplar.Add(yeniHesap);
        }
    }
}
