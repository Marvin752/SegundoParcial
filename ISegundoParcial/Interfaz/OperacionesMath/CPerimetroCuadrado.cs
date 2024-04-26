using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISegundoParcial.Interfaz.OperacionesMath
{
    internal class CPerimetroCuadrado : IOperaGx
    {
        private double r = 0;
        public void calculo(double x, double y)
        {
            r = (x + y) * 2;
        }
        public void resultado()
        {
            Console.WriteLine($"El perimetro de la figura cuadrada es: {r}");
        }
    }
}
