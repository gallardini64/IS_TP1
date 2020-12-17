using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using System;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Presentacion.Vistas
{
    public partial class VistaAcceso : FormBase, IVistaSesion
    {
        PresentadorAcceso _presentador;
        public VistaAcceso()
        {
            InitializeComponent();
            _presentador = new PresentadorAcceso(this);
        }

        public void IniciarSesion(EmpleadoDto empleado, bool sesion)
        {
            if (sesion)
            {
                if (empleado.Rol == "SupervisorLinea")
                {

                    PresentadorLinea presentador = new PresentadorLinea(new VistaSupervisorDeLinea(), empleado);

                    this.Visible = false;
                }
                else
                {
                    if (empleado.Rol == "SupervisorCalidad")
                    {
                        PresentadorOP presentador = new PresentadorOP(new VistaOP(), empleado);
                        this.Visible = false;
                    }
                }
            }
            else
            {
                if (empleado != null)
                {
                    MessageBox.Show("No hay ninguna OP activa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Error al iniciar sesión", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            var tupla = _presentador.IniciarSesion(tbUsuario.Text, tbContrasenia.Text);
            IniciarSesion(tupla.Item2, tupla.Item1);
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
