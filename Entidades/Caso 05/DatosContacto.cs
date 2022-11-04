using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Caso_06
{
    internal class DatosContacto
    {
        public DatosContacto(string pDomicilio, string pTelefono, string pEmail)
        {
            Domicilio = pDomicilio;
            Telefono = pTelefono;
            Email = pEmail;
        }
        public DatosContacto()
        {

        }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
