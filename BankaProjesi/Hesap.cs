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

        public void HesabaParaYatir(decimal yatirilacakMiktar)
        {
            this.bakiye += yatirilacakMiktar;
        }

        public void HesaptanParaCek(decimal cekilecekMiktar)
        {
            bool gelenOnay = ParaCekmeKontrol(cekilecekMiktar);
            if (gelenOnay)
            {
                this.bakiye -= cekilecekMiktar;
                hesaptanCekilentoplamTutar += cekilecekMiktar;
            }

            else
            {
                // cekim olmadı
            }
        }

        public bool ParaCekmeKontrol(decimal cekilecekMiktar)
        {
            bool paraCekmeonay = false;

            if (hesaptanCekilentoplamTutar > 750)
            {
                return paraCekmeonay = false;
            }

            else if (cekilecekMiktar > (bakiye + ekHesap))
            {
                return paraCekmeonay = false;
            }

            else
                return paraCekmeonay = true;
        }
    }
}
