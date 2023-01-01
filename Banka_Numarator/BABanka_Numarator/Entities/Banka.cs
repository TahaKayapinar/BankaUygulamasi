using BABanka_Numarator.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABanka_Numarator.Entities
{
    internal class Banka : IBanka
    {
        public List<Gise> Giseler { get ; set; }
        public List<Musteri> Musteri { get; set; }
        public Numarator numarator { get; set; }
        public Sayac Sayac { get; set; }

        public void MesaiBaslat(int giseSayisi)
        {
            throw new NotImplementedException();
        }

        public void MesaiBitir()
        {
            throw new NotImplementedException();
        }
    }
}
