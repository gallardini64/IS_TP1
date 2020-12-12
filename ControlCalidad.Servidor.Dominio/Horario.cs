using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlCalidad.Servidor.Dominio
{
    public class Horario
    {
       
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public virtual Turno Turno { get; set; }
        public virtual ICollection<Defecto> Defectos { get; set; }
        public virtual ICollection<Par> Pares { get; set; }


        public Horario()
        {
        }
        public Horario(Turno turno)
        {
            Defectos = new List<Defecto>();
            Pares = new List<Par>();
            Turno = turno;
        }
        public void AgregarPar(int numero, Calidad calidad)
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




    }
}