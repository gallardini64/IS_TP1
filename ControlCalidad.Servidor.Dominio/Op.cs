using ControlCalidad.Servidor.Servicio.CapaTransversal;
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
        public Horario HorarioActual { get; set; }


        public Op()
        {
            Horarios = new List<Horario>();
        }

        public bool RegistrarDefecto(int numero, EspecificacionDeDefecto especDe, string pie, DateTime now)
        {
            if (HorarioActual.Turno.SoyTurnoActual())
            {
                HorarioActual.RegistrarDefecto(numero, especDe, pie, now);
                return true;
            }
            else
            {
                if ((int)HorarioActual.Turno.HeFilalizadoHace().TotalMinutes < 10)
                {
                    HorarioActual.RegistrarDefecto(numero, especDe, pie, now);
                    return true;
                }
            }
            return false;
        }

        public bool RegistrarPar(int numero, Calidad calidad)
        {
            if (HorarioActual.Turno.SoyTurnoActual())
            {
                HorarioActual.RegistrarPar(numero, calidad);
                return true;
            }
            else
            {
                if ((int)HorarioActual.Turno.HeFilalizadoHace().TotalMinutes < 10)
                {
                    HorarioActual.RegistrarPar(numero, calidad);
                    return true;
                }
            }
            return false;
        }

        
        public void IniciarNuevoHorario(Turno turno, int id)
        {
            Horario h = new Horario(turno, id);
            Horarios.Add(h);
            HorarioActual = h;
        }
        //TODO: una vez pausada la op se ejecuta este metodo
        public void CerrarHorario()
        {

        }

        public void ConfirmarOP(int numero,Color color1, Modelo modelo1, Turno turno, Linea lineaC, int idHorario)
        {
            Id = numero;
            Numero = numero;
            FechaInicio = DateTime.Now;
            Color = color1;
            Modelo = modelo1;
            IniciarNuevoHorario(turno, idHorario);
            Linea = lineaC;
            Estado = EstadoOP.Activa;
        }
    }
}
