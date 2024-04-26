using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegado.Clasesdelegadas
{
    public class Television
    {
        public static string Mostratele(string m)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return $"El programa de hoy sera de: {m}";
           
        }
    }
}
