using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class ModeloDto
    {
        [DataMember]
        public string Sku { get; set; }
        [DataMember]
        public string Denominacion { get; set; }
        [DataMember]
        public int Objetivo { get; set; }
    }
}
