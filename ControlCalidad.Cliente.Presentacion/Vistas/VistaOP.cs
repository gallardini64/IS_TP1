using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario;
using ControlCalidad.Servidor.Servicio;
using ControlCalidad.Servidor.Servicio.Entidades;
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
        }

        public void ActivarControles(OpDto op)
        {
            throw new NotImplementedException();
        }

        public void AgregarDefecto(int id, string pie)
        {
            throw new NotImplementedException();
        }

        public void CargarOrden(OpDto op)
        {
            throw new NotImplementedException();
        }

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
            List<EspecificacionDeDefectoDto> especificacionDeDefectos = _presentadorOP.ObtenerEspecificacionesDefectosTipo("Reprocesado");
            int cant = especificacionDeDefectos.Count;
            for (int i = 0; i < cant; i++)
            {
                DefectoAgregar panelDefectos = new DefectoAgregar(_presentadorOP);
                panelDefectos.setParametros(this, especificacionDeDefectos[i].Id);
                panelDefectos.Location = new Point(defectoAgregarRep.Location.X, defectoAgregarRep.Location.Y + 90 * i);
                pReprocesado.Controls.Add(panelDefectos);
                _panelesDefecto.Add(panelDefectos);
            }
            //bindingSourceED.DataSource = especificacionDeDefectos;
            //foreach (DataGridViewRow item in DataGridDefectos.Rows)
            //{
            //    item.Cells[2].Value = 0;
            //}
        }





    }
}
