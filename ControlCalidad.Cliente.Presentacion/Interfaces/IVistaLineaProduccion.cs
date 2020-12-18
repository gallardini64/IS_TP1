using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Interfaces
{
    public interface IVistaLineaProduccion
    {
        void Desplegar();
        void ActualizarTurno(TurnoDto turno);
        void ActualizarDatosDeOPActual(OpDto opActual);
    }
}
