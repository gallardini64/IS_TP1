using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Interfaces
{
    public interface IVistaInteractiva
    {
        void Cerrar();
        void MostrarMensaje(string mensaje, bool esError = false);
    }
}
