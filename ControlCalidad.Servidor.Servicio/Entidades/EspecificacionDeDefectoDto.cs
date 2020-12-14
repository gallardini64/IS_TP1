using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class EspecificacionDeDefectoDto
    {
        [DataMember]

        public int Id { get; set; }
        [DataMember]
        public TipoDefectoDto TipoDefecto { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
