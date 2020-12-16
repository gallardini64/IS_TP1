using System;

namespace ControlCalidad.Servidor.Dominio
{
    public class Defecto: EntityBase
    {
        public DateTime Hora { get; set; }
        public int Cantidad { get; set; }
        public Pie Pie { get; set; }
        public virtual EspecificacionDeDefecto EspecificacionDeDefecto { get; set; }

        private Empleado _empleado;
        public virtual Empleado Empleado
        {
            get
            {
                return _empleado;
            }
            set
            {
                if (value.Rol == Rol.SupervisorCalidad)
                {
                    _empleado = value;
                }
            }
        }
        

        public Defecto(EspecificacionDeDefecto especDe, string pie, DateTime now,Empleado empleado)
        {
            EspecificacionDeDefecto = especDe;
            if (pie == "Izquiedo")
            {
                Pie = Pie.Izquierdo;
            }
            else
            {
                Pie = Pie.Derecho;
            }
            Hora = now;
            Empleado = empleado;
        }
    }
}