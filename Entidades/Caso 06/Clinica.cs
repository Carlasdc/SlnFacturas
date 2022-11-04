using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_06
{
    internal class Clinica
    {
        public Clinica(string pNombre, string pApellido, Director pDirector)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Director = pDirector;
        }
        public Clinica()
        {

        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Director Director { get; set; }
    }
}
