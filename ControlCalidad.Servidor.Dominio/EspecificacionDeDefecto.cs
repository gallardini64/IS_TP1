using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class EspecificacionDeDefecto: EntityBase
    {
        public TipoDefecto TipoDefecto { get; set; }
        public string Descripcion { get; set; }
    }
}
