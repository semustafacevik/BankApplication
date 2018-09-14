using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Musteri_Ticari : Musteri
    {
        public override bool ParaHavale(Hesap gonderenHesap, Hesap alacakHesap, decimal gonderilecekMiktar)
        {
            base.ParaHavale(gonderenHesap, alacakHesap, gonderilecekMiktar);
            alacakHesap.hangiMusteriyeait.HesabaParaYatir(alacakHesap, gonderilecekMiktar);

            return true;
        }
    }
}
