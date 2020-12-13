using System.Runtime.Serialization;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class PieDto
    {
        [DataMember]
        public string Pie { get; set; }

    }
}