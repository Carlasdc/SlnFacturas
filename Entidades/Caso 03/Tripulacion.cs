using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_03
{
    internal class Tripulacion
    {
        public Tripulacion(int numeroVuelo, List<Azafata> listaAzafatas)
        {
            NumeroVuelo = numeroVuelo;
            this.listaAzafatas = listaAzafatas;
        }
        public Tripulacion()
        {

        }
        public int NumeroVuelo { get; set; }
        public List<Azafata> listaAzafatas { get; set; }
    }
}
