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

namespace ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario
{
    public partial class Hermanado : UserControl
    {
        private IVistaOP _vista;
        public Hermanado()
        {
            InitializeComponent();
        }

        public void SetVista(IVistaOP vista)
        {
            _vista = vista;
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

        private void btAgregarPrimera_Click(object sender, EventArgs e)
        {
            _vista.RegistrarPar(1, "Primera");
        }

        private void btQuitarPrimera_Click(object sender, EventArgs e)
        {
            _vista.RegistrarPar(-1, "Primera");
        }

        private void btAgregarSegunda_Click(object sender, EventArgs e)
        {
            _vista.RegistrarPar(1, "Segunda");
        }

        private void btQuitarSegunda_Click(object sender, EventArgs e)
        {
            _vista.RegistrarPar(-1, "Segunda");
        }

        internal void ActualizarContadores(int numero, string calidad)
        {
            if (calidad == "Primera")
            {
                if (Int32.Parse(lbContadorPrimera.Text) == 0 && numero < 0) { }
                else
                {
                    lbContadorPrimera.Text = (Int32.Parse(lbContadorPrimera.Text) + numero).ToString();
                }
                
            }
            else
            {
                if (Int32.Parse(lbContadorSegunda.Text) == 0 && numero < 0) { }
                else
                {
                    lbContadorSegunda.Text = (Int32.Parse(lbContadorSegunda.Text) + numero).ToString();
                }
                
            }
        }
    }
}
