using System;
using System.Runtime.Serialization;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class ParDto
    {
        [DataMember]
        public string calidad { get; set; }

        [DataMember]
        public DateTime Hora { get; set; }
    }
}