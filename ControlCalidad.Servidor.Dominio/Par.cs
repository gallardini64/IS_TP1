using System;

namespace ControlCalidad.Servidor.Dominio
{
    public class Par: EntityBase
    {
        public Calidad Calidad { get; set; }
        public DateTime Hora { get; set; }
        public Par(DateTime now,Calidad calidad ,Empleado empleado, TimeSpan? hora = null)
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
            Empleado = empleado;
            
            Calidad = calidad;
        }

        public Par()
        {

        }

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
    }
}