using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_03
{
    internal class Azafata
    {
        public Azafata(string pNombre, string pApellido, Tripulacion pTripulacion)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Tripulacion = pTripulacion;
        }
        public Azafata()
        {

        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Tripulacion Tripulacion { get; set; }
    }
}
