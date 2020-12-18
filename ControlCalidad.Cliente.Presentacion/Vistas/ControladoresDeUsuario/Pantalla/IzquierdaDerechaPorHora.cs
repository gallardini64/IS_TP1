﻿using System;
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
    public partial class IzquierdaDerechaPorHora : UserControl
    {
        public IzquierdaDerechaPorHora()
        {
            InitializeComponent();
        }
        public void SetHora(string hora)
        {
            lbHora.Text = hora;
        }

        public void  CambiarCabecera()
        {
            lbizq.Text = "PRI";
            lbDer.Text = "OBJ";
        }
    }
}
