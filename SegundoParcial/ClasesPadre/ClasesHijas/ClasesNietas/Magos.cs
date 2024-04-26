using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.ClasesPadre.ClasesHijas.ClasesNietas
{
    internal class Magos : Guerreros
    {
        public Magos()
        {
            if (nombre == null || !this.nombre.Equals(""))
                this.nombre = "La gran sombra";
            this.edad = 27;
        }
        public Magos(string nombre, int edad) : this()
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public int potencie { get; set; } = 25;
        public string echizosquesabe { get; set; } = "2";
        public override string ATACAR()
        {
            return "Lanza un echizo";
        }
        public void potenciar()
        {
            if (PotenciaAtaque <= 150)
            {
                PotenciaAtaque += potencie;
            }
            else
            {
                PotenciaAtaque = ataquemax;
            }
        }
    }
}
