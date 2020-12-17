﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Turno : EntityBase
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string Descripcion { get; set; }

        public Turno(DateTime inicio, DateTime fin)
        {
            Inicio = inicio;
            Fin = fin;
        }
        public Turno()
        {

        }

        public override string ToString()
        {
            return Descripcion;
        }
        public List<string> GetListaDeHoras()
        {
            List<string> listaHoras = new List<string>();
            int total = Math.Abs(Fin.Subtract(Inicio).Hours);
            DateTime inicio = Inicio;
            for (int i = 1; i <= total; i++)
            {
                listaHoras.Add(inicio.ToString("HH:00"));
                inicio = inicio.AddHours(1);
            }
            return listaHoras;
        }
        public bool SoyTurnoActual()
        {
            var HoraInicio = Inicio.TimeOfDay;
            var HoraFin = Fin.TimeOfDay;
            var hora = DateTime.Now.TimeOfDay;

            return HoraInicio <= HoraFin ?
            hora >= HoraInicio && hora < HoraFin:
            hora >= HoraInicio || hora < HoraFin;
        }

        
        public TimeSpan HeFilalizadoHace()
        {
            return DateTime.Now.Subtract(Fin);
        }
    }
}
