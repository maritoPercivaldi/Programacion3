using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Almacenaje
    {
        public int IdAlmacenaje { get; set; }
        public string NombreAlmacenaje { get; set; }
        public float ValorAlmacenado { get; set; }
        public IList<Rack> Estructura { get; set; }
        public Ubicacion Coordenadas { get; set; }
        
    }
}
