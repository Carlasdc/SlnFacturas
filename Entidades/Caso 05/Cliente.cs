using Entidades.Caso_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_05
{
    internal class Cliente:DatosContacto
    {
        public Cliente (string pDomicilio, string pTelefono, string pEmail, Empleado pEmpleado) : base(pDomicilio, pTelefono, pEmail)
        {
            Empleado = pEmpleado;
        }
        public Cliente()
        {

        }
        public Empleado Empleado{ get; set; }
    }
}
