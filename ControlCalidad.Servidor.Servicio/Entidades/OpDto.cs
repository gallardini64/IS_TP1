using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class OpDto
    {
        [DataMember]
        public int Numero { get; set; }
        [DataMember]
        public DateTime FechaInicio { get; set; }
        [DataMember]
        public DateTime FechaFin { get; set; }
        [DataMember]
        public ModeloDto Modelo { get; set; }
        [DataMember]
        public ColorDto Color { get; set; }
        [DataMember]
        public List<HorarioDto> Horarios { get; set; }
        [DataMember]
        public LineaDto Linea { get; set; }
        [DataMember]
        public EstadoOPDto Estado { get; set; }
    }
}
