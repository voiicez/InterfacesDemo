using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2.Services.Bases
{
     interface IKoseliHesaplaService
    {
        double AlanHesapla(double taban, double yukseklik);
        double CevreHesapla(double taban, double yukseklik);
    }
}
