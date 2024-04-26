using ISegundoParcial.Interfaz;
using ISegundoParcial.Interfaz.OperacionesMath;
int salir = 0;
do
{
    try
    {
        int op = 0;
        int a, b;
        IOperaGx Operaciones = new CSumare();
        do
        {
            Console.Clear();
            Console.WriteLine("¿Qué desea hacer hoy?\n");
            Console.WriteLine("1) Sumar");
            Console.WriteLine("2) Restar");
            Console.WriteLine("3) Multiplicar");
            Console.WriteLine("4) Dividir");
            Console.WriteLine("5) Encontrar area de una figura cuadrada");
            Console.WriteLine("6) Encontrar perimetro de una figura cuadrada");
            Console.WriteLine("0) Salir\n");
            Console.Write("> ");
            op = Convert.ToInt32(Console.ReadLine());
            if (op != 0)
            {
                do
                {
                    switch (op)
                    {
                        case 1:
                            Operaciones = new CSumare();
                            break;
                        case 2:
                            Operaciones = new CResta();
                            break;
                        case 3:
                            Operaciones = new CMultiplicacion();
                            break;
                        case 4:
                            Operaciones = new CDivision();
                            break;
                        case 5:
                            Operaciones = new CAreaCuadrado();
                            break;
                        case 6:
                            Operaciones = new CPerimetroCuadrado();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("El numero ingresado no es valido\n");
                            Console.WriteLine("Presione Enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("¿Qué desea hacer hoy?\n");
                            Console.WriteLine("1) Sumar");
                            Console.WriteLine("2) Restar");
                            Console.WriteLine("3) Multiplicar");
                            Console.WriteLine("4) Dividir");
                            Console.WriteLine("5) Encontrar area de una figura cuadrada");
                            Console.WriteLine("6) Encontrar perimetro de una figura cuadrada");
                            Console.WriteLine("0) Salir\n");
                            Console.Write("> ");
                            op = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }while (op != 1 && op != 2 && op != 3 && op != 4 && op != 5 && op != 6 && op != 7);
                Console.Clear();
                Console.WriteLine("Ingrese el primer numero\n");
                Console.Write("> ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Ingrese el segundo numero\n");
                Console.Write("> ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Operaciones.calculo(a, b);
                Operaciones.resultado();
                Console.ReadKey();
            }

        }while(op!=0);
        salir = 1;
    }
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("Ingreso un carcter invalido\n");
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadKey();
    }
} while (salir != 1);