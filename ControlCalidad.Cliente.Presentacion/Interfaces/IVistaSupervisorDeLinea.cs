
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Interfaces
{
    public interface IVistaSupervisorDeLinea
    {
        void IniciarOP();
        //void CargarOrden(OpDto op);
        void MostrarObjetivo();
        //void ListarDefectos(ICollection<DefectoDto> defectos);
    }
}
