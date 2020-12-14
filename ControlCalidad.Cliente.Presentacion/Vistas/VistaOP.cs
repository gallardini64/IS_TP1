using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario;
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
    public partial class VistaOP : Form, IVistaOP
    {
        private PresentadorOP _presentadorOP;
        private List<DefectoAgregar> _panelesDefecto = new List<DefectoAgregar>();
        public VistaOP()
        {
            InitializeComponent();
            _presentadorOP = new PresentadorOP(this);
            CargarDefectosDeReprocesado();
        }

        //public void ActivarControles(OpDto op)
        //{
        //    throw new NotImplementedException();
        //}

        public void RegistrarDefecto(int idEspDefecto, int numero, string pie)
        {
            _presentadorOP.RegistrarDefecto(idEspDefecto, numero, pie);
        }

        //public void CargarOrden(OpDto op)
        //{
        //    throw new NotImplementedException();
        //}

        public void DesactivarControles()
        {
            throw new NotImplementedException();
        }

        public void LimpiarCamposOP()
        {
            throw new NotImplementedException();
        }

        private void CargarDefectosDeReprocesado()
        {
            dynamic[] especificacionDeDefectos = _presentadorOP.ObtenerEspecificacionesDefectosTipo("Reprocesado");
            var i = 0;
            foreach (var item in especificacionDeDefectos)
            {
                DefectoAgregar panelDefectos = new DefectoAgregar();
                panelDefectos.setParametros(this, item.id, item.Descripcion);
                panelDefectos.Location = new Point(defectoAgregarRep.Location.X, defectoAgregarObs.Location.Y + 90 * i);
                pReprocesado.Controls.Add(panelDefectos);
                _panelesDefecto.Add(panelDefectos);
                i++;
            }
        }
        public void ActualizarNumeroDeDefectosTipo(int idEspDefecto, int numero, string pie)
        {
            _panelesDefecto.FirstOrDefault(e => e._id == idEspDefecto).RegistrarDefectoTipo(numero);
        }





    }
}
