using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario : Persona
    {
        public string UserName { get; set; }
        public string Secret { get; set; }
        public Permiso Autorizacion { get; set; }


    }
}
