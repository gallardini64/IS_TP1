using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario.Pantalla
{
    public partial class DefectoCelda : UserControl
    {
        public DefectoCelda()
        {
            InitializeComponent();
        }

        public void SetTexto(string texto)
        {
            lbText.Text = texto;
        }
    }
}
