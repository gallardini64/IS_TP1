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
    public class PresentadorAcceso: IControlCalidadServicioCallback
    {
        public IVistaSesion _vista;
        public PresentadorAcceso(IVistaSesion vista)
        {
            _vista = vista;
            Adaptador.SetContexto(this);
        }

        public (bool, EmpleadoDto) IniciarSesion (string usuario, string contraseña)
        {
            return Adaptador.IniciarSesion(usuario, contraseña);
        }

        public void OnOPCambiaDeEstado(string estado, int numeroOP)
        {
            throw new NotImplementedException();
        }
    }
}
