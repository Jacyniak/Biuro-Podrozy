using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podrozy
{
    interface IZarzadzaj
    {
        void DodajExpress(int iloscMiejsc);
        void DodajSamolot(int iloscMiejsc, int odleglosc);
        void UsunOstatni();
        void Wyczysc();
    }
}
