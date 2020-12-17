using ControlCalidad.Cliente.AccesoExterno;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario;
using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
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
    public partial class VistaOP : FormBase, IVistaOP
    {
        private PresentadorOP _presentadorOP;
        private List<DefectoAgregar> _panelesDefecto = new List<DefectoAgregar>();
        public OpDto opActual { get; set; }
        public TurnoDto turnoActual { get; set; }
        public VistaOP()
        {
            InitializeComponent();

        }
        public void SetPresentador(PresentadorOP presentadorOP, string empleado)
        {
            _presentadorOP = presentadorOP;
        }
        public void CargarOpActual()
        {
            opActual = _presentadorOP.AsignarOPaSupervisorDeCalidad();
            tbOpNum.Text = opActual.Numero.ToString();

        }




        private void CargarDatosDeTurnoActual()
        {
            turnoActual = _presentadorOP.ObtenerDatosDeTurnoActual(opActual);
            cbHora.DataSource = turnoActual.Horas;
            tbTurno.Text = turnoActual.Descripcion;
        }
        public void RegistrarDefecto(int idEspDefecto, int numero, string pie)
        {
            _presentadorOP.RegistrarDefecto(idEspDefecto, numero, pie);
        }
        public void DesactivarControles()
        {
            throw new NotImplementedException();
        }

        public void LimpiarCamposOP()
        {
            throw new NotImplementedException();
        }
        public void Desplegar()
        {
            CargarDatosDeTurnoActual();
            CargarDefectosDeReprocesado();
            CargarDefectosDeObservado();
            Show();
        }
        private void CargarDefectosDeReprocesado()
        {
            EspecificacionDeDefectoDto[] especificacionDeDefectos = _presentadorOP.ObtenerEspecificacionesDefectosTipo("Reprocesado");
            var i = 0;
            foreach (var item in especificacionDeDefectos)
            {
                DefectoAgregar panelDefectos = new DefectoAgregar();
                panelDefectos.setParametros(this, item.Id, item.Descripcion);
                panelDefectos.Location = new Point(defectoAgregarRep.Location.X, defectoAgregarObs.Location.Y + 90 * i);
                pReprocesado.Controls.Add(panelDefectos);
                _panelesDefecto.Add(panelDefectos);
                i++;
            }
        }
        private void CargarDefectosDeObservado()
        {
            EspecificacionDeDefectoDto[] especificacionDeDefectos = _presentadorOP.ObtenerEspecificacionesDefectosTipo("Observado");
            var i = 0;
            foreach (var item in especificacionDeDefectos)
            {
                DefectoAgregar panelDefectos = new DefectoAgregar();
                panelDefectos.setParametros(this, item.Id, item.Descripcion);
                panelDefectos.Location = new Point(defectoAgregarObs.Location.X, defectoAgregarObs.Location.Y + 90 * i);
                pReprocesado.Controls.Add(panelDefectos);
                _panelesDefecto.Add(panelDefectos);
                i++;
            }
        }
        public void ActualizarNumeroDeDefectosTipo(int idEspDefecto, int numero, string pie)
        {
            _panelesDefecto.FirstOrDefault(e => e._id == idEspDefecto).RegistrarDefectoTipo(numero);
        }

        private void VistaOP_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp(sender, e);
        }

        private void VistaOP_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }

        private void VistaOP_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

    }
}
