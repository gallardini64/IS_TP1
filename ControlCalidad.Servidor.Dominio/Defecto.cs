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
        

        public Defecto(EspecificacionDeDefecto especDe, string pie, DateTime now,Empleado empleado,TimeSpan? hora = null)
        {
            if (hora == null)
            {
                Hora = now;
            }
            else
            {
                Hora = now;
                if ((Hora.Date + hora) > now)
                {
                    Hora = ((DateTime)(Hora.Date + hora)).AddDays(-1);
                }
                else
                {
                    Hora = (DateTime)(Hora.Date + hora);
                }
                
            }
            EspecificacionDeDefecto = especDe;
            if (pie == "Izquierdo")
            {
                Pie = Pie.Izquierdo;
            }
            else
            {
                Pie = Pie.Derecho;
            }
            
            Empleado = empleado;

        }

        public Defecto()
        {

        }
    }
}