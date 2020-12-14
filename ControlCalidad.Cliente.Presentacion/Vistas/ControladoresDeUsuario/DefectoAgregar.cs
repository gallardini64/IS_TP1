using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCalidad.Cliente.Presentacion.Presentadores;

namespace ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario
{
    public partial class DefectoAgregar : UserControl
    {
        private PresentadorOP _presentadorOP;
        private VistaOP _vistaOP;
        private int _id;

        public DefectoAgregar()
        {
            InitializeComponent();
        }
        public DefectoAgregar(PresentadorOP presentador)
        {
            InitializeComponent();
            _presentadorOP = presentador;
        }

        private void btnAgregarDefectoDer_Click(object sender, EventArgs e)
        {
            
        }
        public void setParametros(VistaOP vista, int id, string descripcion)
        {
            _vistaOP = vista;
            _id = id;
            lbDefecto.Text = $"{descripcion} {_id}";
        }
    }
}
