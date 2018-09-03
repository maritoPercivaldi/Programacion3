using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Deposito : Empresa
    {
        public int IdDeposito { get; set; }
        public string NombreDeposito { get; set; }
        public IList<Almacenaje> Almacenado { get; set; }

    }
}
