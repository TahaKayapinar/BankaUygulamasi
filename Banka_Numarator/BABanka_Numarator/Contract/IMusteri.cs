using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABanka_Numarator.Contract
{
    internal interface IMusteri
    {
        string TcNo { get; set; }
        int Numara { get; set; }
    }
}
