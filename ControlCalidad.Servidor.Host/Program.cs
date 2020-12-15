using ControlCalidad.Servidor.Dominio;
using ControlCalidad.Servidor.Servicio;
using ControlCalidad.Servidor.Servicio.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Turno t = new Turno(DateTime.Now, DateTime.Now.AddHours(8));
            List<string> horas = t.GetListaDeHoras().ToList();
            foreach (var item in horas)
            {
                Console.WriteLine(item);
            }
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);



        }
    }
}
