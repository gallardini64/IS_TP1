using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Turno
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
        public bool SoyTurnoActual()
        {
            if (Inicio.Hour < DateTime.Now.Hour && DateTime.Now.Hour < Fin.Hour) return true;
            else return false;
        }
        public TimeSpan HeFilalizadoHace()
        {
            return DateTime.Now.Subtract(Fin);
        }
    }
}
