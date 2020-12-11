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
        public Modelo Modelo { get; set; }
        public Color Color { get; set; }
        private List<Horario> Horarios = new List<Horario>();
        



    }
}
