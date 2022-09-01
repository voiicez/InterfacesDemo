using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemo2.Services.Bases;

namespace InterfacesDemo2.Services
{
    internal class DarieHesaplaService : IKosesizHesaplaService
    {
        double pi = Math.PI;
        public double AlanHesapla(double yariCap)
        {
            return pi * Math.Pow(yariCap, 2);
        }

        public double CevreHesapla(double yariCap)
        {
            return 2 * pi * yariCap;
        }
    }
}
