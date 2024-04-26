using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.ClasesPadre.ClasesHijas.ClasesNietas
{
    internal class Wyvern : Guerreros
    {
        public Wyvern()
        {
            if (nombre == null || !this.nombre.Equals(""))
                this.nombre = "El dragón oscuro";
            this.edad = 27;
        }
        public Wyvern(string nombre, int edad) : this()
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ATACAR()
        {
            return "Rasguña";
        }
        public int volar { get; set; } = 1;
        public void volara()
        {
            if (volar == 1)
            {
                volar = 0;
            }
            else
            {
                volar = 1;
            }
        }
        public string mensaje()
        {
            if(volar == 0)
            {
                return "El dragón esta volando";
            }
            else
            {
                return "El dragón esta en el suelo";
            }
        }
        public override void Mostrardetalles()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Vida: {vida}");
            Console.WriteLine($"Potencia de ataque: {PotenciaAtaque}");
            Console.WriteLine(mensaje());
        }
    }
    
}
