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
            VerificarEstadoOP();
            tbOpNum.Text = opActual.Numero.ToString();
            tbFec.Text = opActual.FechaInicio.ToString("dd/MM/yyyy");

        }

        private void VerificarEstadoOP()
        {
            if (opActual.Estado == "Activa")
            {
                OpActiva();
            }
            else
            {
                OpPausada();
            }
        }

        private void OpPausada()
        {
            Phermanado.Habilitarse();
            btHermanado.Enabled = true;
        }

        private void OpActiva()
        {
            Phermanado.Deshabilitarse();
            btHermanado.Enabled = false;
        }

        private void CargarDatosDeTurnoActual()
        {
            turnoActual = _presentadorOP.ObtenerDatosDeTurnoActual(opActual);
            cbHora.DataSource = turnoActual.Horas;
            tbTurno.Text = turnoActual.Descripcion;
        }
        public void RegistrarDefecto(int idEspDefecto, int numero, string pie)
        {
            _presentadorOP.RegistrarDefecto(idEspDefecto, numero, pie,opActual.Numero);
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
            foreach (var especificacion in especificacionDeDefectos)
            {
                DefectoAgregar panelDefectos = new DefectoAgregar();
                panelDefectos.setParametros(this, especificacion.Id, especificacion.Descripcion,CargarContadoresDefecto(especificacion.Id));
                panelDefectos.Location = new Point(defectoAgregarRep.Location.X, defectoAgregarRep.Location.Y + 90 * i);
                pReprocesado.Controls.Add(panelDefectos);
                _panelesDefecto.Add(panelDefectos);
                i++;
            }
        }
        private void CargarDefectosDeObservado()
        {
            EspecificacionDeDefectoDto[] especificacionDeDefectos = _presentadorOP.ObtenerEspecificacionesDefectosTipo("Observado");
            var i = 0;
            foreach (var especificacion in especificacionDeDefectos)
            {
                DefectoAgregar panelDefectos = new DefectoAgregar();
                panelDefectos.setParametros(this, especificacion.Id, especificacion.Descripcion,CargarContadoresDefecto(especificacion.Id));
                panelDefectos.Location = new Point(defectoAgregarObs.Location.X, defectoAgregarObs.Location.Y + 90 * i);
                pObservado.Controls.Add(panelDefectos);
                _panelesDefecto.Add(panelDefectos);
                i++;
            }
        }

        private (int,int) CargarContadoresDefecto(int id)
        {
            var horario = opActual.Horarios.LastOrDefault();
            
            if (horario != null)
            {
                var contadorderecho = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Derecho").Count();
                var contadorizquierdo = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Izquierdo").Count();
                return (contadorderecho, contadorizquierdo);
            }
            return (0, 0);
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

        public void ActualizarParesCalidad(int numero, string calidad)
        {
            lbContadorPrimera.Text = (Int32.Parse(lbContadorPrimera.Text) + numero).ToString();
        }

        public void MostrarMensaje(string v)
        {
            MessageBox.Show(v);
        }

        private void btnAgregarPar_Click(object sender, EventArgs e)
        {
            _presentadorOP.RegistrarPar(1, "Primera", opActual.Numero);
        }

        private void btnQuitarPar_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lbContadorPrimera.Text) != 0)
            {
                _presentadorOP.RegistrarPar(-1, "Primera", opActual.Numero);
            }
        }
    }
}
