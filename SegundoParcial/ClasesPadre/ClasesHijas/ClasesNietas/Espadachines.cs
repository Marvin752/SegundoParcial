using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.ClasesPadre.ClasesHijas.ClasesNietas
{
    internal class Espadachines : Guerreros
    {
        public string ataquesquesabe { get; set; } = "2";
        public override string ATACAR()
        {
            return "Le pega con la espada";
        }
    }
}
