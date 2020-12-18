using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario.Pantalla;
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
        private List<IzquierdaDerechaPorHora> _pHorasHead = new List<IzquierdaDerechaPorHora>();
        public VistaLineaProduccion()
        {
            InitializeComponent();
            
        }

        public void ActualizarDatosDeOPActual(OpDto opActual)
        {

        }

        public void ActualizarTurno(TurnoDto turno)
        {
            int i = 0;
            foreach (var h in turno.Horas)
            {
                IzquierdaDerechaPorHora izqDerPorHora = new IzquierdaDerechaPorHora();
                izqDerPorHora.SetHora(h);
                izqDerPorHora.Location = new Point(izquierdaDerechaPorHora.Location.X + izquierdaDerechaPorHora.Size.Width * i, izquierdaDerechaPorHora.Location.Y);

                pDefectos.Controls.Add(izqDerPorHora);
                _pHorasHead.Add(izqDerPorHora);
                i++;
            }

            foreach (var h in turno.Horas)
            {

            }





        }

        public void CargarHoras(TurnoDto turnoActual)
        {

        }
        public void Desplegar()
        {
            Show();
        }
    }
}
