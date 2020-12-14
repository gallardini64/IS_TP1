using ControlCalidad.Cliente.AccesoExterno;
using ControlCalidad.Cliente.Presentacion.Interfaces;

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

        public dynamic[] ObtenerEspecificacionesDefectosTipo(string v)
        {
            return Adaptador.ObtenerEspecificacionesDefectosTipo(v);
        }
    }
}
