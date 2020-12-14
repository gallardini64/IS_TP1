using ControlCalidad.Servidor.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Interfaces
{
    public interface IVistaSupervisorDeLinea
    {
        void CargarOrden(OpDto op);
        void MostrarObjetivo(int objetivo);
        void ListarDefectos(ICollection<DefectoDto> defectos);
    }
}
