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
    public class PresentadorLinea
    {
        private IVistaSupervisorDeLinea _vista;
        public PresentadorLinea(IVistaSupervisorDeLinea vista)
        {
            _vista = vista;
        }
        public (ColorDto[], ModeloDto[], LineaDto[]) IniciarOP()
        {
            return Adaptador.InicializarOp();
        }
    }
}
