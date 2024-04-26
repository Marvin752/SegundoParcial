using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegado.Clasesdelegadas
{
    public class Radio
    {
        public static string Mensaje(string m)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return $"Estamos al aire, con el tema de: {m}";
        }
    }
}
