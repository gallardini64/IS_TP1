﻿using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using ControlCalidad.Servidor.Servicio;
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
    }
}
