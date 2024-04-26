using SegundoParcial.ClasesPadre;
using SegundoParcial.ClasesPadre.ClasesHijas;
using SegundoParcial.ClasesPadre.ClasesHijas.ClasesNietas;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
int salir = 0;
do
{
    try
    {
        Console.Clear();
        int op = 0;
        int x = 0;
        Random random = new Random();
        Magos mango = new Magos();
        Wyvern draco = new Wyvern();
        Console.WriteLine("Bienvenido aventurero\n");
        Console.WriteLine("¿Cúal es tu nombre?\n");
        Console.Write("> ");
        mango.nombre = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("¿Cúal es tu edad?\n");
        Console.Write("> ");
        mango.edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("¿Con cuanta vida deseas comenzar? (1000 maximo)\n");
        Console.Write("> ");
        mango.vida = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.Clear();
            Console.WriteLine("Detalles del personaje");
            mango.Mostrardetalles();
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("Detalles del enemigo");
            draco.Mostrardetalles();
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Atacar");
            Console.WriteLine("2. Potenciar");
            Console.WriteLine("3. Curar");
            Console.WriteLine();
            Console.Write("> ");
            op = Convert.ToInt32(Console.ReadLine());

            if (mango.vida > 0)
            {
                do
                {
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine(mango.ATACAR());
                            draco.vida -= mango.PotenciaAtaque;
                            Console.WriteLine($"Vida de Dráco después del ataque: {draco.vida}");
                            Console.WriteLine("Presione Enter para continuar");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine();
                            mango.potenciar();
                            Console.WriteLine("Se a potenciado el ataque en: " + mango.PotenciaAtaque);
                            Console.WriteLine("Presione Enter para continuar");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine();
                            mango.curar();
                            Console.WriteLine("Se a curado la vida del personaje en: " + mango.vida);
                            Console.WriteLine("Presione Enter para continuar");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("La opción seleccionada no es valida");
                            Console.WriteLine("Selecciona una opción:");
                            Console.WriteLine("1. Atacar");
                            Console.WriteLine("2. Potenciar");
                            Console.WriteLine("3. Curar");
                            Console.WriteLine();
                            Console.Write("> ");
                            op = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                } while (op != 1 && op != 2 && op != 3);
            }
            if (draco.vida > 0)
            {
                x = random.Next(1, 4);
                switch (x)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine(draco.ATACAR());
                        mango.vida -= draco.PotenciaAtaque;
                        Console.WriteLine($"Vida de {mango.nombre} después del ataque: {mango.vida}");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine();
                        draco.volara();
                        Console.WriteLine(draco.mensaje());
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine();
                        mango.curar();
                        Console.WriteLine("Se a curado la vida de enemigo " + draco.vida);
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("La opción seleccionada no es valida");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadKey();
                        break;
                }
            }
        } while (mango.vida > 0 && draco.vida > 0);
        if (mango.vida <= 0)
        {
            Console.WriteLine($"{draco.nombre} fue demasiado fuerte esta vez");
            salir = 1;
        }
        else if (draco.vida <= 0)
        {
            Console.WriteLine($"{draco.nombre} no fue rival para ti");
            salir = 1;
        }
    }
    catch (Exception)
    {
        Console.WriteLine();
        Console.WriteLine("Ingresate un caracter invalido\n");
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadKey();
    }
}while (salir != 1) ;