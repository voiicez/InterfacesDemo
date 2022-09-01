using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemo2.Services.Bases;

namespace InterfacesDemo2.Services
{
    internal class DikUcgenHesaplaService : IKoseliHesaplaService
    {
        public double AlanHesapla(double taban, double yukseklik)
        {
            return taban * yukseklik / 2;
        }

        public double CevreHesapla(double taban, double yukseklik)
        {
            double pisagor = 0;
            pisagor = Math.Sqrt(taban * taban + yukseklik * yukseklik);
            return taban + yukseklik + pisagor;
        }
    }


}
