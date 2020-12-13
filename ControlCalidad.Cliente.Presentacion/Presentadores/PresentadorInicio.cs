using ControlCalidad.Cliente.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Presentadores
{
    public class PresentadorInicio
    {
        public IVistaLineaProduccion vistaLinea;
        public PresentadorInicio()
        {
            PresentadorAcceso presentadorAcceso = new PresentadorAcceso();
        }
    }
}
