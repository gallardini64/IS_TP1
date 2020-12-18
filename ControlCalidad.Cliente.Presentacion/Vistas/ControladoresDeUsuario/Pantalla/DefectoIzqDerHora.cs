using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario.Pantalla
{
    public partial class DefectoIzqDerHora : UserControl
    {
        public int acumuladoDer { get; set; }
        public int acumuladoIzq { get; set; }
        public DefectoIzqDerHora()
        {
            InitializeComponent();
        }

        public void SetContadores(int derecha, int izquierda)
        {
            lbContDer.Text = derecha.ToString();
            lbContIzq.Text = izquierda.ToString();
        }
        public void SetContadores()
        {
            lbContDer.Text = acumuladoDer.ToString();
            lbContIzq.Text = acumuladoIzq.ToString();
        }

        public (int derecha, int izquierda) GetContadores()
        {
            return (int.Parse(lbContDer.Text), int.Parse(lbContIzq.Text));
        }
    }
}
