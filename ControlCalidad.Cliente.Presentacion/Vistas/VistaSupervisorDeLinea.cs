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
    //TODO agregar el cerrar sesion
    public partial class VistaSupervisorDeLinea : FormBase, IVistaSupervisorDeLinea
    {
        private PresentadorLinea _presentadorLinea;
        private ModeloDto[] _modelos;
        private ColorDto[] _colores;
        private LineaDto[] _lineas;

        public OpDto opActual { get; set; }

        public VistaSupervisorDeLinea()
        {
            InitializeComponent();         
        }

        public void SetPresentador(PresentadorLinea presentador, string usuario)
        {
            _presentadorLinea = presentador;
            IniciarOP(_presentadorLinea.GetOp(usuario));
        }
        public void IniciarOP(OpDto op)
        {
            
            if (op == null)
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
            else
            {
                pNuevaOP.Visible = false;
                btnCrearOP.Enabled = false;
                opActual = op;
                CargarOpActual(opActual);
                _presentadorLinea.ActualizarPantalla(opActual);
                if (opActual.Estado == "Pausada")
                {
                    btReanudarOP.Visible = true;
                }
            }
        }

        private void CargarOpActual(OpDto op)
        {
            tbFecOpAct.Text = op.FechaInicio.ToString("dd/MM/yyyy");
            tbLineaOpAct.Text = op.Linea.Numero.ToString();
            tbModeloOpAct.Text = op.Modelo.Denominacion;
            tbNroOpAct.Text = op.Numero.ToString();
            tbObjetivoOpAct.Text = op.Modelo.Objetivo.ToString();
        }

        private void btnCrearOP_Click(object sender, EventArgs e)
        {
            if(opActual != null)
            {
                MessageBox.Show("Ya existe una OP en proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    opActual = new OpDto();
                    opActual.Numero = numero;
                    opActual.Linea = linea;
                    opActual.Modelo = modelo;
                    opActual.Color = color;
                    opActual.FechaInicio = DateTime.Now;
                    CargarOpActual(opActual);
                    pNuevaOP.Visible = false;
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
        public void Desplegar()
        {
            Show();
        }

        private void btnPausarOP_Click(object sender, EventArgs e)
        {
           
           var resultado = _presentadorLinea.PausarOP(opActual.Numero);
            
            if (resultado)
            {
                btReanudarOP.Visible = true;
                opActual.Estado = "Pausada";
            }
            else
            {
                MessageBox.Show("Error al pausar la OP"); 
            }
        }

        private void btReanudarOP_Click(object sender, EventArgs e)
        {
            var resultado =_presentadorLinea.ReanudarOP(opActual.Numero);
            if (resultado.Item1)
            {
                opActual.Estado = "Activa";
                btReanudarOP.Visible = false;
            }
            else
            {
                MessageBox.Show($"{resultado.Item2}", "Reanudar OP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnFinalizarOP_Click(object sender, EventArgs e)
        {
            bool resultado = _presentadorLinea.FinalizarOP(opActual.Numero);
            if (resultado)
            {
                VaciarCampos();
                opActual = new OpDto();
                MessageBox.Show($"La OP se finalizó correctamente", "Finalizar OP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al finalizar la OP", "Finalizar OP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VaciarCampos()
        {
            pNuevaOP.Visible = true;
            tbFecOpAct.Text = "";
            tbLineaOpAct.Text = "";
            tbModeloOpAct.Text = "";
            tbNroOpAct.Text = "";
            tbObjetivoOpAct.Text = "";
        }
    }
}
