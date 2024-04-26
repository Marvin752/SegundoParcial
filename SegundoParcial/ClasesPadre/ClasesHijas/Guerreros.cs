using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.ClasesPadre.ClasesHijas
{
    internal class Guerreros : Aventureros
    {
        protected int cure = 50;
        protected int ataquemax = 150;
        public int PotenciaAtaque = 75;
        protected int vidadefecto = 1000;
        private int vidaMaxima = 700;
        public virtual string ATACAR()
        {
            return "Lanza un ataque";
        }
        public int vida
        {
            get
            {
                return vidadefecto;
            }
            set
            {
                if (value > 0 && value <= 1000)
                {
                    vidadefecto = value;
                }
                else if (value < vidadefecto)
                {
                    // Si el nuevo valor es menor que el valor actual de vidadefecto (después de un ataque),
                    // actualizamos vidadefecto con el nuevo valor
                    vidadefecto = value;
                }
            }
        }
        public void curar()
        {
            if (vida < vidaMaxima)
            {
                vida += cure;
                if (vida > vidaMaxima)
                {
                    vida = vidaMaxima; //Aca la vida no supera el maximo
                }
            }
        }
        public virtual void Mostrardetalles()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Vida: {vida}");
            Console.WriteLine($"Potencia de ataque: {PotenciaAtaque}");
        }
    }
}
