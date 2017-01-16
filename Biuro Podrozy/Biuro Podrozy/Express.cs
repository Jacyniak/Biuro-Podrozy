using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podrozy
{
    class Express : SrodekLokomocji
    {
        public void CenaExpress(int iloscMiejsc){
            base.iloscMiejsc = this.iloscMiejsc;
            base.ObliczCene();
        }
        public override string ToString() {
            return "Express: ilosc miejsc: " + Convert.ToString(base.iloscMiejsc) + ", cena biletu: " + 
                Convert.ToString(base.cenaBiletu);
        }
    }
}
