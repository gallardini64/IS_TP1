using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario
{
    public partial class Hermanado : UserControl
    {
        public Hermanado()
        {
            InitializeComponent();
        }

        public void Deshabilitarse()
        {
            btAgregarPrimera.Enabled = false;
            btAgregarSegunda.Enabled = false;
            btQuitarPrimera.Enabled = false;
            btQuitarSegunda.Enabled = false;
        }
        public void Habilitarse()
        {
            btAgregarPrimera.Enabled = true;
            btAgregarSegunda.Enabled = true;
            btQuitarPrimera.Enabled = true;
            btQuitarSegunda.Enabled = true;
        }
        public void ActualizarContador(int primera, int segunda)
        {
            lbContadorPrimera.Text = primera.ToString();
            lbContadorSegunda.Text = segunda.ToString();
        }
    }
}
