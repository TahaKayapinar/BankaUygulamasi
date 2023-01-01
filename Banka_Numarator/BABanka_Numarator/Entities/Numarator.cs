using BABanka_Numarator.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABanka_Numarator.Entities
{
    public class Numarator : INumarator
    {
        public Numarator()    // program ilk ayağa kaldırılırken atamaları yapılmış olarak ctor un içi çalışacak ynai
        {
            VipSiraSayisiSayaci = 1000;
            GiseSiraSayisiSayaci = 2000;
            BireyselSiraSayisiSayaci = 3000;
        }

        // public int VipSiraSayisiSayaci { get; set; }  // 1000 den başlasın    (1000-1999)
        //  public int GiseSiraSayisiSayaci { get; set; }  //  2000 den başlasın   (2000-2999)
        // public int BireyselSiraSayisiSayaci { get; set; }  //  3000 den başlasın   (3000 - +)

        private int _bireyselSayac;

        public int BireyselSiraSayisiSayaci
        {
            get { return _bireyselSayac; }
            set
            {
                if (value >= 3000)
                {
                    _bireyselSayac = value;
                }
                else
                {
                    throw new Exception("Girilen sayı 3000'den küçük olmamalıdır");
                }
            }
        }

        private int _giseSayac;

        public int GiseSiraSayisiSayaci
        {
            get { return _giseSayac; }
            set
            {
                if (value >= 2000 && value < 3000)
                {
                    _giseSayac = value;
                }
                else
                {
                    throw new Exception("Girilen sayı 2000 ile 3000 arasında değildir");

                }
            }
        }

        private int _vipSayac;

        public int VipSiraSayisiSayaci
        {
            get { return _giseSayac; }
            set
            {
                if (value >= 1000 && value < 2000)
                {
                    _vipSayac = value;
                }
                else
                {
                    throw new Exception("Girilen sayı 1000 ile 2000 arasında değildir");
                }
            }
        }

        public void NumaraUret()
        {
            throw new NotImplementedException();
        }
    }
}
