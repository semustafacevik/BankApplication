using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Banka
    {
        public List<Musteri> musteriler = new List<Musteri>();


        public void BankayaMusteriEkle(Musteri yeniMusteri)
        {
            musteriler.Add(yeniMusteri);
        }
    }
}
