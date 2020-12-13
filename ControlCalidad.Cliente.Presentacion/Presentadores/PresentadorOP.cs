using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Presentadores
{
    public class PresentadorOP
    {
        private IVistaOP _vista;
        public PresentadorOP(IVistaOP vista)
        {
            _vista = vista;
        }
        public void AgregarDefecto(int numero) 
        {
        
        }

        internal List<EspecificacionDeDefectoDto> ObtenerEspecificacionesDefectosTipo(string v)
        {
            throw new NotImplementedException();
        }
    }
}
