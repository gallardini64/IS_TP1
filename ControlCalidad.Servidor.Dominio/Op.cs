using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Op: EntityBase
    {
        public int Numero { get; set; }
        public DateTime FechaInicio { get; set; }
        public Nullable<DateTime> FechaFin { get; set; } 
        public virtual Modelo Modelo { get; set; }
        public virtual Color Color { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
        public virtual Linea Linea { get; set; }

        private Empleado _empleado;
        public virtual Empleado Empleado
        {
            get
            {
                return _empleado;
            }
            set
            {
                if (value.Rol == Rol.SupervisorLinea)
                {
                    _empleado = value;
                }
            }
        }

        private EstadoOP _estado;
        public EstadoOP Estado{ 
            get
            {
                return _estado;
            } 
            set
            {
                if (_estado != EstadoOP.Finalizada)
                {
                    _estado = value;
                }
            } 
        }



        public Op()
        {
            Horarios = new List<Horario>();
        }

        public bool RegistrarDefecto(int numero, EspecificacionDeDefecto especDe, string pie, DateTime now, Empleado empleado)
        {
            Horario horarioActual = Horarios.LastOrDefault();
            if (horarioActual.Turno.SoyTurnoActual())
            {
                horarioActual.RegistrarDefecto(numero, especDe, pie, now,empleado);
                return true;
            }
            else
            {
                if ((int)horarioActual.Turno.HeFilalizadoHace().TotalMinutes < 10)
                {
                    horarioActual.RegistrarDefecto(numero, especDe, pie, now,empleado);
                    return true;
                }
            }
            return false;
        }

        public bool RegistrarPar(int numero, Calidad calidad,Empleado empleado, Horario horario = null)
        {
            if (horario == null)
            {
                Horario horarioActual = Horarios.LastOrDefault();
                if (horarioActual.Turno.SoyTurnoActual())
                {
                    horarioActual.RegistrarPar(numero, calidad, empleado);
                    return true;
                }
                else
                {
                    if ((int)horarioActual.Turno.HeFilalizadoHace().TotalMinutes < 10)
                    {
                        horarioActual.RegistrarPar(numero, calidad, empleado);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                horario.RegistrarPar(numero, calidad, empleado);
                return true;
            }
        }

        
        public void IniciarNuevoHorario(Turno turno)
        {
            if(Horarios.Count > 0) CerrarHorario();
            Horarios.Add(new Horario(turno));
        }
        //TODO: una vez pausada la op se ejecuta este metodo
        public void CerrarHorario()
        {
            Estado = EstadoOP.Pausada;
            Horarios.Last().Fin = DateTime.Now;
        }

        public void ConfirmarOP(int numero,Color color1, Modelo modelo1, Turno turno, Linea lineaC, Empleado empleado)
        {
            Id = numero;
            Numero = numero;
            FechaInicio = DateTime.Now;
            Color = color1;
            Modelo = modelo1;
            IniciarNuevoHorario(turno);
            Linea = lineaC;
            Estado = EstadoOP.Activa;
            Empleado = empleado;
        }

        //TODO crear metodo finalizar OP
    }
}
