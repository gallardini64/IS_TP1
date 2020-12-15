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
        public DateTime FechaFin { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Color Color { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
        public virtual Linea Linea { get; set; }
        public EstadoOP Estado{ get; set; }
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
                if ((int)HorarioActual.Turno.HeFilalizadoHace().TotalMinutes <
                    FactoriaDeEstrategias.GetInstancia().GetEstrategiaTiempoLimite().getMinLimiteDeTiempoDeOperaciones())
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
                if ((int)HorarioActual.Turno.HeFilalizadoHace().TotalMinutes <
                    FactoriaDeEstrategias.GetInstancia().GetEstrategiaTiempoLimite().getMinLimiteDeTiempoDeOperaciones())
                {
                    HorarioActual.RegistrarPar(numero, calidad);
                    return true;
                }
            }
            return false;
        }

        public void ConfirmarOP(Turno turno)
        {
            Estado = EstadoOP.Activa;
            Horarios.Add(new Horario(turno));
        }
        public void IniciarNuevoHorario(Turno turno)
        {
            Horario h = new Horario(turno);
            Horarios.Add(h);
            HorarioActual = h;
        }


    }
}
