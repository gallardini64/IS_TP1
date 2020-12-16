using System;

namespace ControlCalidad.Servidor.Dominio
{
    public class Par: EntityBase
    {
        public Calidad Calidad { get; set; }
        public DateTime Hora { get; set; }
        public Par(DateTime now,Calidad calidad ,Empleado empleado)
        {
            Empleado = empleado;
            Hora = now;
            Calidad = calidad;
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