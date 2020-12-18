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
        public void RegistrarPar(int numero, Calidad calidad, Empleado empleado, TimeSpan? hora = null)
        {
            if (numero > 0)
            {
                Par par = new Par(DateTime.Now, calidad,empleado,hora);
                Pares.Add(par);
            }
            if (numero < 0)
            {
                if (Pares.Count() > 0)
                {
                    var par = Pares.ToList().LastOrDefault(p => p.Calidad.Equals(calidad));
                    Pares.Remove(par);
                }
               
            }
        }

        public void RegistrarDefecto(int numero, EspecificacionDeDefecto especDe, string pie, DateTime now,Empleado empleado,TimeSpan? hora = null)
        {
            if (numero > 0)
            {
                Defecto defecto = new Defecto(especDe, pie, now,empleado,hora);
                Defectos.Add(defecto);
            }
            if (numero < 0)
            {
                

                if (hora != null)
                {
                    if (hora > ((TimeSpan)hora).Add(TimeSpan.Parse("01:00")))
                    {
                        var defecto = Defectos.ToList().LastOrDefault(d => d.EspecificacionDeDefecto.Equals(especDe) &&
                                                                   d.Pie.ToString().Equals(pie) && (d.Hora.TimeOfDay >= hora || d.Hora.TimeOfDay < ((TimeSpan)hora).Add(TimeSpan.Parse("01:00"))));
                        Defectos.Remove(defecto);
                    }
                    else
                    {
                        var defecto = Defectos.ToList().LastOrDefault(d => d.EspecificacionDeDefecto.Equals(especDe) &&
                                                                   d.Pie.ToString().Equals(pie) && d.Hora.TimeOfDay >= hora && d.Hora.TimeOfDay < ((TimeSpan)hora).Add(TimeSpan.Parse("01:00")));
                        Defectos.Remove(defecto);
                    }
                    
                }
                else
                {
                    var defecto = Defectos.ToList().LastOrDefault(d => d.EspecificacionDeDefecto.Equals(especDe) &&
                                                                                       d.Pie.ToString().Equals(pie));
                    Defectos.Remove(defecto);
                }
                
            }
        }
    }
}