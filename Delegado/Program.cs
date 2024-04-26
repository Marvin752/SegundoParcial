using Delegado.Clasesdelegadas;

namespace Delegado
{
    public delegate string Delegar(string m);

    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de la instancia del delegado
            Delegar Chamba = new Delegar(Radio.Mensaje);

            // Llamada al método a través del delegado
            Chamba("Mitologia sobre dinosaurios");

            Chamba = new Delegar(Television.Mostratele);

            Chamba("Spy White vs Spy Black");
        }
    }
}