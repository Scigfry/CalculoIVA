using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIVA
{
    public class Calculadora
    {

        double cantidadAPagar;
        byte tipoIVA;

        public Calculadora(double cantidadAPagar, byte tipoIVA)
        {
            this.cantidadAPagar = cantidadAPagar;
            this.tipoIVA = tipoIVA;
        }

        private double Porcentaje()
        {
            double porcentaje;
            switch (tipoIVA)
            {
                case 1: porcentaje = 0.1; break;
                case 2: porcentaje = 0.04; break;
                default: porcentaje = 0.21; break;
            }
            return porcentaje;
        }

        public double totalSinIVA()
        {
            return cantidadAPagar / (1 + Porcentaje());
        }

        public double IVA()
        {
            return cantidadAPagar - totalSinIVA();
        }
    }
}
