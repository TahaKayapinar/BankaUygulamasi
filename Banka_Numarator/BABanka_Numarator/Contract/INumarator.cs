using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABanka_Numarator.Contract
{
    internal interface INumarator
    {
        void NumaraUret();
        int VipSiraSayisiSayaci { get; set; }
        int GiseSiraSayisiSayaci { get; set; }
        int BireyselSiraSayisiSayaci { get; set; }
    }
}
