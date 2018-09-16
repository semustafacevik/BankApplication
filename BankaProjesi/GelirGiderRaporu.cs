using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class GelirGiderRaporu
    {
        public decimal girenPara;
        public decimal cikanPara;
        public decimal toplamPara;

        public GelirGiderRaporu()
        {

        }

        public void RaporEt(decimal tutar, string islem)
        {
            switch (islem)
            {
                case "girenpara":
                    girenPara += tutar;
                    toplamPara += tutar;
                    break;

                case "cikanpara":
                    tutar *= -1;
                    cikanPara += tutar;
                    toplamPara -= tutar;
                    break;

                default:
                    break;
            }
        }

    }
}
