using ControlCalidad.Servidor.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Controladores
{
    public class ControladorLineas
    {
        private Repositorio _repositorio = Repositorio.GetInstancia();

        public LineaDto[] GetLineas()
        {
            return _repositorio
                .GetLineas()
                .Select(l => new LineaDto
                {
                    Numero = l.Numero,
                })
                .ToArray();
        }


    }
}
