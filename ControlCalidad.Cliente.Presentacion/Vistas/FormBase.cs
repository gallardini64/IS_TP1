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

namespace ControlCalidad.Cliente.Presentacion.Vistas
{
    public partial class FormBase : Form, IVistaInteractiva
    {
        #region Movimiento
        protected int mov;
        protected int movX;
        protected int movY;
        #endregion
        public FormBase()
        {
            InitializeComponent();
        }

        public void Cerrar()
        {
            Close();
        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            MessageBox.Show(mensaje, "soft", MessageBoxButtons.OK,
                esError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }
        protected void FormBase_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }
        protected void mouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        protected void mouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        protected void mouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
