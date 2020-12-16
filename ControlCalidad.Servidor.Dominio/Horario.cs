using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlCalidad.Servidor.Dominio
{
    public class Horario : EntityBase
    {
       
        public DateTime Inicio { get; set; }
        public Nullable<DateTime> Fin { get; set; }
        public virtual Turno Turno { get; set; }
        public virtual ICollection<Defecto> Defectos { get; set; }
        public virtual ICollection<Par> Pares { get; set; }
        public virtual Op Op { get; set; }

        public Horario()
        {

        }
        
        public Horario(Turno turno)
        {
            Inicio = DateTime.Now;
            Defectos = new List<Defecto>();
            Pares = new List<Par>();
            Turno = turno;
        }
        public void RegistrarPar(int numero, Calidad calidad)
        {
            if (numero > 0)
            {
                Par par = new Par(DateTime.Now, calidad);
                Pares.Add(par);
            }
            if (numero < 0)
            {
                var par = Pares.ToList().LastOrDefault(p => p.Calidad.Equals(calidad));
                Pares.Remove(par);
            }
        }

        internal void RegistrarDefecto(int numero, EspecificacionDeDefecto especDe, string pie, DateTime now)
        {
            if (numero > 0)
            {
                Defecto defecto = new Defecto(especDe, pie, now);
                Defectos.Add(defecto);
            }
            if (numero < 0)
            {
                var defecto = Defectos.ToList().LastOrDefault(d => d.EspecificacionDeDefecto.Equals(especDe) &&
                                                                   d.Pie.ToString().Equals(pie));
                Defectos.Remove(defecto);
            }
        }
    }
}