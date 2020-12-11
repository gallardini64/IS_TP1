using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Op
    {
        public int Numero { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Color Color { get; set; }
        public virtual List<Horario> Horarios { get; set; }
        public virtual Linea Linea { get; set; }




    }
}
