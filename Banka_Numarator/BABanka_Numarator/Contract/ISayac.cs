using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABanka_Numarator.Contract
{
    internal interface ISayac
    {
        int VipMusteriSayisi { get; set; }
        int GiseMusteriSayisi { get; set; }
        int BireyselMusteriSayisi { get; set; }

        void GisedenIsiBitenNumaraAl(INumara numara);
    }
}
