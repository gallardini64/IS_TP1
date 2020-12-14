using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class DefectoDto
    {
        [DataMember]
        public DateTime Hora { get; set; }
        [DataMember]
        public int Cantidad { get; set; }
        [DataMember]
        public PieDto Pie { get; set; }
        [DataMember]
        public EspecificacionDeDefectoDto EspecificacionDeDefecto { get; set; }
    }
}
