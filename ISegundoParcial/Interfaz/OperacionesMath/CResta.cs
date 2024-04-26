using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISegundoParcial.Interfaz.OperacionesMath
{
    internal class CResta : IOperaGx
    {
        private double r = 0;
        public void calculo(double x, double y)
        {
            r = x - y;

        }
        public void resultado()
        {
            Console.WriteLine($"El resultado de la suma es: {r}");
        }
    }
}
