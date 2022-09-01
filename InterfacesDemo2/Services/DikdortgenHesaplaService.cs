using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemo2.Services.Bases;

namespace InterfacesDemo2.Services
{
    internal class DikdortgenHesaplaService : IKoseliHesaplaService
    {
        public double AlanHesapla(double taban, double yukseklik)
        {
            return taban * yukseklik;
        }

        public double CevreHesapla(double taban, double yukseklik)
        {
            return 2 * (taban + yukseklik);
        }
    }
}
