using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_01
{
    internal class Usuario
    {
        public Usuario(string pNombre, string pApellido, Cliente pCliente)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Cliente = pCliente;
        }
        public Usuario()
        {

        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Cliente Cliente { get; set; }
    }
}
