using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Rack
    {
        public int IdRack { get; set; }
        public string NombreRack { get; set; }
        public float AlturaMaxima { get; set; }
        public float PesoMaximo { get; set; }
        public IList<Material> Contenido { get; set; }
        public bool Full { get; set; }

    }
}
