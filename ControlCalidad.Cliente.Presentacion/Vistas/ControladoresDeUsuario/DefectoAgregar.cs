﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCalidad.Cliente.Presentacion.Presentadores;

namespace ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario
{
    public partial class DefectoAgregar : UserControl
    {
        private VistaOP _vistaOP;
        public int _id;

        public DefectoAgregar()
        {
            InitializeComponent();
        }


        private void btnAgregarDefectoDer_Click(object sender, EventArgs e)
        {
            _vistaOP.RegistrarDefecto(_id,1, "DERECHO");
        }
        public void setParametros(VistaOP vista, int id, string descripcion)
        {
            _vistaOP = vista;
            _id = id;
            lbDefecto.Text = $"{descripcion} {_id}";
        }
        public void RegistrarDefectoTipo(int numero)
        {
            lbContadorDer.Text = (Int32.Parse(lbContadorDer.Text) + numero).ToString();
        }




        public void Desactivar()
        {
            btnAgregarDefectoDer.Enabled = false;
            btnAgregarDefectoIzq.Enabled = false;
            btnQuitarDefectoDer.Enabled = false;
            btnQuitarDefectoIzq.Enabled = false;
        }
        public void Activar()
        {
            btnAgregarDefectoDer.Enabled = true;
            btnAgregarDefectoIzq.Enabled = true;
            btnQuitarDefectoDer.Enabled = true;
            btnQuitarDefectoIzq.Enabled = true;
        }



    }
}
