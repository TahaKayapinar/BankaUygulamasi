using BABanka_Numarator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABanka_Numarator.Contract
{
    internal interface IBanka
    {
        List<Gise> Giseler { get; set; }
        List<Musteri> Musteri { get; set; }

        Numarator numarator { get; set; }

        Sayac Sayac { get; set; }


        void MesaiBaslat(int giseSayisi);
        void MesaiBitir();
    }
}
