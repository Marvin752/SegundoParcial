using Indexer.ClasesIndex;
using Indexer.ClasesIndex.HerenciaIndex;

//Creamos la lista de estudiantes

Estudiante estudiante = new Estudiante();

//Mostramos el estudiante en esa posicion

Uni lista = estudiante[1];
lista.MostrarInfo();

//Colocamos un estudiante nuevo en la posicion 1

Uni otrolisatdo = new Uni("Pablo", "0905-23-48956");
estudiante[1] = otrolisatdo;

//Imprimimos todos los estudiantes

for(int i = 0; i < 4; i++)
{
    estudiante[i].MostrarInfo();
}