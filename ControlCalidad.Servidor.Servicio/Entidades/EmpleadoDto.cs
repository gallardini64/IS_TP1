using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class EmpleadoDto
    {
        [DataMember]
        public int Documento { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}
