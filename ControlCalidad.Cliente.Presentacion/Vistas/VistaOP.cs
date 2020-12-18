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
        private List<DefectoAgregar> _panelDefectos = new List<DefectoAgregar>();
        
        public OpDto opActual { get; set; }
        public TurnoDto turnoActual { get; set; }

        public bool EstaCargandoEnHoraActual { get; set; } = true;
        private TimeSpan Hora { get; set; }
        public VistaOP()
        {
            InitializeComponent();
            Hora = TimeSpan.Parse(DateTime.Now.ToString("HH:00"));
            
        }
        public void SetPresentador(PresentadorOP presentadorOP, string empleado)
        {
            _presentadorOP = presentadorOP;
        }
        public void CargarOpActual()
        {
            opActual = _presentadorOP.AsignarOPaSupervisorDeCalidad();
            tbOpNum.Text = opActual.Numero.ToString();
            tbFec.Text = opActual.FechaInicio.ToString("dd/MM/yyyy");
            CargarContadorPares();
        }

        private void CargarContadorPares()
        {
            
                var horamas1 = Hora.Add(TimeSpan.Parse("01:00"));
                if (Hora <= horamas1)
                {
                    lbContadorPrimera.Text = opActual.Horarios.LastOrDefault().Pares.Where(p => p.calidad == "Primera" &&
                        (p.Hora.TimeOfDay >= Hora && p.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count().ToString();
                }
                else
                {
                    lbContadorPrimera.Text = opActual.Horarios.LastOrDefault().Pares.Where(p => p.calidad == "Primera" &&
                        (p.Hora.TimeOfDay >= Hora || p.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count().ToString();
                }
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
            btHermanado.Enabled = true;
            foreach (var panel in _panelDefectos)
            {
                panel.Desactivar();
            }
            btnAgregarPar.Enabled = false;
            btnQuitarPar.Enabled = false;
        }

        private void OpActiva()
        {
            Phermanado.Deshabilitarse();
            btHermanado.Enabled = false;
            foreach (var panel in _panelDefectos)
            {
                panel.Activar();
            }
            btnAgregarPar.Enabled = true;
            btnQuitarPar.Enabled = true;
        }

        private void CargarDatosDeTurnoActual()
        {
            turnoActual = _presentadorOP.ObtenerDatosDeTurnoActual(opActual);
            cbHora.DataSource = turnoActual.Horas;
            var index = 0;
            foreach (var hora in turnoActual.Horas)
            {
                if (DateTime.Now.TimeOfDay >= TimeSpan.Parse(hora) && DateTime.Now.TimeOfDay < TimeSpan.Parse(hora).Add(TimeSpan.Parse("01:00")))
                {
                    break;
                }
                index++;
            }
            cbHora.SelectedIndex = index;

            tbTurno.Text = turnoActual.Descripcion;
        }
        public void RegistrarDefecto(int idEspDefecto, int numero, string pie)
        {
            if (EstaCargandoEnHoraActual)
            {
                _presentadorOP.RegistrarDefecto(idEspDefecto, numero, pie, opActual.Numero);
            }
            else
            {
                _presentadorOP.RegistrarDefecto(idEspDefecto, numero, pie, opActual.Numero,Hora);
            }
            
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
            CargarDefectosDeReprocesado();
            CargarDefectosDeObservado();
            CargarDatosDeTurnoActual();
            VerificarEstadoOP();
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
                _panelDefectos.Add(panelDefectos);
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
                _panelDefectos.Add(panelDefectos);
                i++;
            }
        }

        private (int,int) CargarContadoresDefecto(int id)
        {
            var horario = opActual.Horarios.LastOrDefault();

       

            if (horario != null)
            {
                var horamas1 = Hora.Add(TimeSpan.Parse("01:00"));
                if (Hora <= horamas1)
                {
                    var contadorderecho = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Derecho"
                                && (e.Hora.TimeOfDay >= Hora && e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    var contadorizquierdo = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Izquierdo"
                                && (e.Hora.TimeOfDay >= Hora && e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    return (contadorderecho, contadorizquierdo);
                }
                else
                {
                    var contadorderecho = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Derecho"
                                && (e.Hora.TimeOfDay >= Hora || e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    var contadorizquierdo = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Izquierdo"
                                && (e.Hora.TimeOfDay >= Hora || e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    return (contadorderecho, contadorizquierdo);
                }
                
            }
            return (0, 0);
        }

        public void ActualizarNumeroDeDefectosTipo(int idEspDefecto, int numero, string pie)
        {   
                _panelDefectos.FirstOrDefault(e => e._id == idEspDefecto).RegistrarDefectoTipo(numero, pie);
         
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
            if (opActual.Estado == "Pausada")
            {
                Phermanado.ActualizarContadores(numero, calidad);
            }
            else
            {
                lbContadorPrimera.Text = (Int32.Parse(lbContadorPrimera.Text) + numero).ToString();
            }
            
        }

        public void MostrarMensaje(string v)
        {
            MessageBox.Show(v);
        }

        private void btnAgregarPar_Click(object sender, EventArgs e)
        {
            RegistrarPar(1,"Primera");

        }

        public void RegistrarPar(int numero, string calidad)
        {

            if (EstaCargandoEnHoraActual)
            {
                _presentadorOP.RegistrarPar(numero, calidad, opActual.Numero);
            }
            else
            {
                _presentadorOP.RegistrarPar(numero, calidad, opActual.Numero, Hora);
            }
        }

        private void btnQuitarPar_Click(object sender, EventArgs e)
        {
            RegistrarPar(-1, "Primera");
        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            Hora = TimeSpan.Parse(cbHora.SelectedValue.ToString());
            opActual = _presentadorOP.AsignarOPaSupervisorDeCalidad();
            foreach (var panel in _panelDefectos)
            {
                panel.ActualizarContadores(CargarContadoresDefecto(panel._id));
            }
            CargarContadorPares();
            EstaCargandoEnHoraActual = false;
            btDeshacer.Enabled = true;
        }

        private void btDeshacer_Click(object sender, EventArgs e)
        {
            btFiltrar.Enabled = true;
            btDeshacer.Enabled = false;
            Hora = TimeSpan.Parse(DateTime.Now.ToString("HH:00"));
            opActual = _presentadorOP.AsignarOPaSupervisorDeCalidad();
            foreach (var panel in _panelDefectos)
            {
                panel.ActualizarContadores(CargarContadoresDefecto(panel._id));
            }
            CargarContadorPares();
            RetornarAHoraActual();
        }

        public void RetornarAHoraActual()
        {
            var index = 0;
            foreach (var hora in turnoActual.Horas)
            {
                if (DateTime.Now.TimeOfDay >= TimeSpan.Parse(hora) && DateTime.Now.TimeOfDay < TimeSpan.Parse(hora).Add(TimeSpan.Parse("01:00")))
                {
                    break;
                }
                index++;
            }
            cbHora.SelectedIndex = index;
        }

        private void btHermanado_Click(object sender, EventArgs e)
        {
            Phermanado.Habilitarse();
            Phermanado.SetVista(this);
            var primera = opActual.Horarios.LastOrDefault().Pares.Where(p => p.calidad == "Primera").Count();
            var segunda = opActual.Horarios.LastOrDefault().Pares.Where(p => p.calidad == "Segunda").Count();
            Phermanado.ActualizarContador(primera,segunda);
        }
    }
}
