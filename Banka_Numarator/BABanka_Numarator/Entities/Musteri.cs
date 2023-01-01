using BABanka_Numarator.Contract;
using BABanka_Numarator.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABanka_Numarator.Entities
{
    public class Musteri : IMusteri
    {
        public string TcNo { get; set; }
        public MusteriTipi musteriTipi { get; set; }
        public int Numara { get; set; }
    }
}
