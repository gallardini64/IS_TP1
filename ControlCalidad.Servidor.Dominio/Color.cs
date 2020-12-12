using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Color : EntityBase
    {
        public string Descripcion { get; set; }
        public int Codigo { get; set; }
    }
}
