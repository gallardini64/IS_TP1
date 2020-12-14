using ControlCalidad.Servidor.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Interfaces
{
    public interface IVistaOP
    {
        
        void DesactivarControles();
        
        void LimpiarCamposOP();
        void AgregarDefecto(int id, string pie);
    }
}
