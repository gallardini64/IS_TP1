using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
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
    public partial class VistaSupervisorDeLinea : FormBase, IVistaSupervisorDeLinea
    {
        private PresentadorLinea _presentadorLinea;
        private ModeloDto[] _modelos;
        private ColorDto[] _colores;
        private LineaDto[] _lineas;
        public VistaSupervisorDeLinea()
        {
            InitializeComponent();
            _presentadorLinea = new PresentadorLinea(this);
            IniciarOP();
        }

       

        public void IniciarOP()
        {
            var tupla = _presentadorLinea.IniciarOP();

            _colores = tupla.Item1;
            _modelos = tupla.Item2;
            _lineas = tupla.Item3;

            cbColor.DataSource = _colores;
            cbColor.DisplayMember = "Descripcion";
            cbModelo.DataSource = _modelos;
            cbModelo.DisplayMember = "Denominacion";
            
            tbObjetivo.Text = _modelos.FirstOrDefault().Objetivo.ToString();
            cbLinea.DataSource = _lineas;
            cbLinea.DisplayMember = "Numero";
        }

        private void btnCrearOP_Click(object sender, EventArgs e)
        {
            IniciarOP();
        }

        public void MostrarObjetivo()
        {
            ModeloDto modelo = (ModeloDto)cbModelo.SelectedItem;
            tbObjetivo.Text = modelo.Objetivo.ToString();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var numero = int.Parse(tbNumero.Text);
                LineaDto linea = (LineaDto)cbLinea.SelectedItem;
                ModeloDto modelo = (ModeloDto)cbModelo.SelectedItem;
                ColorDto color = (ColorDto)cbColor.SelectedItem;

                (bool,string) resultado = _presentadorLinea.ConfirmarOP(numero, linea, modelo, color);
               
                if (resultado.Item1)
                {
                    MessageBox.Show($"{resultado.Item2}","Creacion OP", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{resultado.Item2}", "Creacion OP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se han ingresado los datos correctamente", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            
        }








        #region Movimiento
        private void VistaSupervisorDeLinea_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp(sender, e);
        }
        private void VistaSupervisorDeLinea_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }
        private void VistaSupervisorDeLinea_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }
        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarObjetivo();
        }
        #endregion

    }
}
