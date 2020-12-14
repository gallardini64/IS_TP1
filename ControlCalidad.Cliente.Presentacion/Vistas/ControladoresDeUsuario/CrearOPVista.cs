using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Servidor.Servicio;


namespace ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario
{
    public partial class CrearOPVista : UserControl
    {
        private IVistaSupervisorDeLinea _vista;
        public CrearOPVista()
        {
            InitializeComponent();
        }
        public void setVista(IVistaSupervisorDeLinea vista)
        {
            _vista = vista;
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LimpiarCampos();
        }

        internal void cargarModelosColoresYLineas(List<LineaDto> lineas, List<ModeloDto> modelos, List<ColorDto> colores)
        {
            cbColor.DataSource = colores;
            cbModelo.DataSource = modelos;
            cbLinea.DataSource = lineas;
        }

        public void LimpiarCampos()
        {
            tbNumero.Clear();
            dpFecha.Value = DateTime.Now;
        }
        public void Cerrar()
        {
            LimpiarCampos();
            this.Hide();
        }
    }
}
