using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podrozy
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public SrodekLokomocji() { }

        public void ObliczCene() {
            this.cenaBiletu = this.iloscMiejsc * 5.23;
        }

        public double Cena(){
            return this.cenaBiletu;
        }
    }
}
