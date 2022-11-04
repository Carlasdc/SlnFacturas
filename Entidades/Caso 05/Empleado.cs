using Entidades.Caso_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_05
{
    internal class Empleado:DatosContacto
    {
        public Empleado(string pDomicilio, string pTelefono, string pEmail, Cliente pCliente):base(pDomicilio, pTelefono, pEmail)
        {
            Cliente = pCliente;
        }
        public Empleado()
        {

        }
        public Cliente Cliente { get; set; }
    }
}
