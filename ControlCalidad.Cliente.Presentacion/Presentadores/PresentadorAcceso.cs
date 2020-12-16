using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Cliente.AccesoExterno;
using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Interfaces;

namespace ControlCalidad.Cliente.Presentacion.Presentadores
{
    public class PresentadorAcceso
    {
        public IVistaSesion _vista;
        public PresentadorAcceso(IVistaSesion vista)
        {
            _vista = vista;
        }

        public (bool, EmpleadoDto) IniciarSesion (string usuario, string contraseña)
        {
            return Adaptador.IniciarSesion(usuario, contraseña);
        }
    }
}
