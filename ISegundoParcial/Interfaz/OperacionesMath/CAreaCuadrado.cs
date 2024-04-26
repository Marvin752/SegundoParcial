using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISegundoParcial.Interfaz.OperacionesMath
{
    internal class CAreaCuadrado : IOperaGx
    {
        private double r = 0;
        public void calculo(double x, double y)
        {
            r = x * y;
        }
        public void resultado()
        {
            Console.WriteLine($"El area de la figura cuadrada es: {r}");
        }
    }
}
