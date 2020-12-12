using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Controladores
{
    public class ControladorLineas
    {
        private Repositorio<Linea> _repositorio = Repositorio<Linea>.GetInstancia();

        public LineaDto[] GetLineas()
        {
            return _repositorio
                .GetAll()
                .Select(l => new LineaDto
                {
                    Numero = l.Numero,
                })
                .ToArray();
        }


    }
}
