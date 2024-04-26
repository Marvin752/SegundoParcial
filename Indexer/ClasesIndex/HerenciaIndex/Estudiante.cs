using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.ClasesIndex.HerenciaIndex
{
    internal class Estudiante
    {
        private Uni[] listado;
        public Estudiante()
        {
            listado = new Uni[4];
            listado[0] = new Uni("Marvin", "0905-23-17848");
            listado[1] = new Uni("Yenci", "0905-23-6756");
            listado[2] = new Uni("Yourgen", "0905-23-14003");
            listado[3] = new Uni("Carlos", "0905-23-18976");
        }
        public Uni this[int index]
        {
            get { return listado[index]; }
            set { listado[index] = value; }
        }
    }
}
