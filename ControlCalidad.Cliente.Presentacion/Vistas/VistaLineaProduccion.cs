using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
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
    public partial class VistaLineaProduccion : Form, IVistaLineaProduccion
    {
        public VistaLineaProduccion()
        {
            InitializeComponent();
        }
        public void ActualizarPantalla(OpDto opActual)
        {

        }
        public void Desplegar()
        {
            Show();
        }
    }
}
