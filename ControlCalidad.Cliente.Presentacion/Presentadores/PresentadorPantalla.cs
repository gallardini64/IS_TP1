using ControlCalidad.Cliente.AccesoExterno;
using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Presentadores
{
    public class PresentadorPantalla
    {
        private IVistaLineaProduccion _vista;
        private OpDto _opActual;
        public PresentadorPantalla(IVistaLineaProduccion vista)
        {
            _vista = vista;
        }
        public void ActualizarOP(OpDto opActual)
        {

        }

        public void ActualizarOP()
        {
            throw new NotImplementedException();
        }
    }
}
