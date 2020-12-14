using System;

namespace ControlCalidad.Servidor.Dominio
{
    public class Defecto: EntityBase
    {
        public DateTime Hora { get; set; }
        public int Cantidad { get; set; }
        public Pie Pie { get; set; }
        public virtual EspecificacionDeDefecto EspecificacionDeDefecto { get; set; }

        public Defecto(Pie pie, string descripcion)
        {
            Pie = pie;
                    
        }

        public Defecto(EspecificacionDeDefecto especDe, string pie, DateTime now)
        {
        }
    }
}