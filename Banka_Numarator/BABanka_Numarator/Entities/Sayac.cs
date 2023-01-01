using BABanka_Numarator.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABanka_Numarator.Entities
{
    internal class Sayac : ISayac
    {
        public Sayac()   // sayaç her program çalıştığında sıfırlanır.  Aslında her gün sıfırlanması gerekli.
        {
            VipMusteriSayisi = 0;
            GiseMusteriSayisi = 0;
            BireyselMusteriSayisi = 0;
        }


        public int VipMusteriSayisi { get; set; }
        public int GiseMusteriSayisi { get; set; }
        public int BireyselMusteriSayisi { get; set; }

        public void GisedenIsiBitenNumaraAl(INumara numara)
        {
            if (numara is VipNumara)
            {
                VipMusteriSayisi++;
            }
            else if (numara is GiseNumara)
            {
                GiseMusteriSayisi++;
            }
            else if (numara is BireyselNumara)
            {
                BireyselMusteriSayisi++;
            }
        }
    }
}
