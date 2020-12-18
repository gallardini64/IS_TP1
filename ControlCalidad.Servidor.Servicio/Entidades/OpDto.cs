using ControlCalidad.Servidor.Servicio;
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
        public List<DefectoDto> Defectos { get; set; }
        [DataMember]
        public List<ParDto> Pares { get; set; }
        [DataMember]
        public LineaDto Linea { get; set; }
        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public EmpleadoDto Empleado { get; set; }

    }
}
