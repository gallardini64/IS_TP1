using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCalidad.Cliente.AccesoExterno;

namespace ControlCalidad.Cliente.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var lineas = Adaptador.GetLineas();
            foreach (var linea in lineas)
            {
                listBox1.Items.Add($"{linea.Numero} - {linea.Descripcion}");  
            }
        }
    }
}
