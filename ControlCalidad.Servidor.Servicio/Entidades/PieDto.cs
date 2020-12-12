using System.Runtime.Serialization;

namespace ControlCalidad.Servidor.Servicio.Entidades
{
    [DataContract]
    public class PieDto
    {
        [DataMember]
        public string Pie { get; set; }

    }
}