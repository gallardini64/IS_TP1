using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using ControlCalidad.Servidor.Servicio;

namespace ControlCalidad.Servidor.Servicio.Controladores
{
    public class ControladorColor
    {
        private Repositorio<Color> _repositorio = Repositorio<Color>.GetInstancia();

        public ColorDto[] GetColores()
        {
            return _repositorio.GetAll().Select(color => new ColorDto
            {
                Descripcion = color.Descripcion,
                Codigo = color.Codigo,

            }).ToArray();
        }
    }
}
