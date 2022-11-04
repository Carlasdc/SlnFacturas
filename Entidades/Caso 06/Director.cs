using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_06
{
    internal class Director
    {
        public Director(string pNombre, string pApellido, Clinica pClinica)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Clinica = pClinica;
        }
        public Director()
        {

        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Clinica Clinica { get; set; }
    }
}
