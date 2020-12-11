using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Servidor.Dominio;

namespace ControlCalidad.Servidor.Datos
{
    public class Repositorio
    {


        private static Repositorio Instancia { get; set; } = null;

        public static Repositorio GetInstancia()
        {
            return Instancia ?? (Instancia = new Repositorio());
        }
        public   IEnumerable<Linea> GetLineas()
        {
            return new List<Linea>()
            {
                new Linea
                {
                    Numero = 1,
                },
                new Linea {
                    Numero =2,
                },
                new Linea
                {
                    Numero=3
                },

            };

        }

        protected Repositorio()
        {

        }
    }
}
