using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class HorarioDto
    {
        [DataMember]
        public DateTime Inicio { get; set; }
        [DataMember]
        public DateTime Fin { get; set; }
    }
}
