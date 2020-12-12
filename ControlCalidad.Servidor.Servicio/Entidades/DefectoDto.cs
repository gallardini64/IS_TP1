using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Entidades
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
        public virtual EspecificacionDeDefectoDto EspecificacionDeDefecto { get; set; }
    }
}
