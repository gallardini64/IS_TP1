using System.Runtime.Serialization;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class ParDto
    {
        [DataMember]
        public string calidad { get; set; }


    }
}