using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Op: EntityBase
    {
        public int Numero { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Color Color { get; set; }
        public virtual List<Horario> Horarios { get; set; }
        public virtual Linea Linea { get; set; }
        public EstadoOP Estado{ get; set; }
        public virtual Horario HorarioActual { get; set; }


        public Op()
        {
            Horarios = new List<Horario>();
            Estado = EstadoOP.Activa;
        }
    }
}
