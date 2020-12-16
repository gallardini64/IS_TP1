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

        

        

        

        public void MostrarObjetivo(int objetivo)
        {
            throw new NotImplementedException();
        }


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
                    MessageBox.Show("Creacion OP", $"{resultado.Item2}", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Creacion OP", $"{resultado.Item2}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "ingrese bien los datos", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            
        }
    }
}
