using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using ControlCalidad.Servidor.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Presentacion.Vistas
{
    public partial class VistaSupervisorDeLinea : FormBase, IVistaSupervisorDeLinea
    {
        private PresentadorLinea _presentadorLinea;
        public VistaSupervisorDeLinea(PresentadorLinea presentadorLinea)
        {
            InitializeComponent();
            _presentadorLinea = presentadorLinea;

        }

        public void CargarOrden(OpDto op)
        {
            throw new NotImplementedException();
        }

        public void IniciarOP()
        {
            _presentadorLinea.IniciarOP();
        }

        public void ListarDefectos(ICollection<DefectoDto> defectos)
        {
            throw new NotImplementedException();
        }

        public void MostrarObjetivo(int objetivo)
        {
            throw new NotImplementedException();
        }
    }
}
