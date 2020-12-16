using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCalidad.Cliente.Presentacion.Presentadores;

namespace ControlCalidad.Cliente.Presentacion.Vistas
{
    public partial class VistaAcceso : FormBase, IVistaSesion
    {
        PresentadorAcceso _presentador;
        public VistaAcceso()
        {
            _presentador = new PresentadorAcceso(this);
            InitializeComponent();

        }

        public void IniciarSesion(EmpleadoDto empleado, bool sesion)
        {
            if (sesion)
            {
                if (empleado.Rol == "SupervisorLinea")
                {

                    PresentadorLinea presentador = new PresentadorLinea(new VistaSupervisorDeLinea(), empleado);
                    
                    this.Close();
                }
                else
                {
                    if (empleado.Rol == "SupervisorCalidad")
                    {
                        PresentadorOP presentador = new PresentadorOP(new VistaOP(), empleado);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error al iniciar sesión", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            var tupla = _presentador.IniciarSesion(tbUsuario.Text, tbContrasenia.Text);
            IniciarSesion(tupla.Item2,tupla.Item1);
        }



        private void Vista_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp(sender, e);
        }

        private void Vista_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }

        private void Vista_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

    }
}
