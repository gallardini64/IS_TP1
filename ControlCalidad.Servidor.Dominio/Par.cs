using System;

namespace ControlCalidad.Servidor.Dominio
{
    public class Par: EntityBase
    {
        public Calidad Calidad { get; set; }
        public DateTime Hora { get; set; }
        public Par(DateTime now,Calidad calidad)
        {
            Hora = now;
            Calidad = calidad;
        }
    }
}