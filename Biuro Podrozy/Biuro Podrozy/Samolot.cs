using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podrozy
{
    class Samolot : SrodekLokomocji
    {
        private int odleglosc;

        public override void ObliczCene() {
            if (this.odleglosc > 200) 
                base.cenaBiletu = odleglosc * 6.41;
            else 
                base.cenaBiletu = 33;
        }

        public void CenaSamolot(int iloscMiejsc, int odleglosc) {
            base.iloscMiejsc = iloscMiejsc;
            this.odleglosc = odleglosc;
            this.ObliczCene();
        }

        public override string ToString() {
            return "Samolot: ilosc miejsc: " + Convert.ToString(base.iloscMiejsc) + ", odleglsc: " + 
                Convert.ToString(this.odleglosc) + ", cena biletu: " + Convert.ToString(base.cenaBiletu);
        }
    }
}
