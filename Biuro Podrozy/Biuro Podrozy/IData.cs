using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podrozy
{
    interface IData
    {
        void UstawDate(DateTime data);
        bool SprawdzDate();
    }
}
