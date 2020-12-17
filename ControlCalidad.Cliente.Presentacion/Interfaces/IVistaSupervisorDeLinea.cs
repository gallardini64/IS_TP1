
using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Interfaces
{
    public interface IVistaSupervisorDeLinea
    {
        void IniciarOP(OpDto op);
        void MostrarObjetivo();
        void SetPresentador(PresentadorLinea presentadorLinea, string usuario);
        void Desplegar();
    }
}
