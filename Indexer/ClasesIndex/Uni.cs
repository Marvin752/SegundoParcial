using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.ClasesIndex
{
    internal class Uni
    {
        string carnet = "0000-00-00000";
        string nombre;

        public Uni(string c, string n)
        {
            carnet = c;
            nombre = n; 
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Carnet: {carnet}");
            Console.WriteLine("==================================");
        }
    }
}
