﻿namespace ControlCalidad.Cliente.Presentacion.Vistas
{
    partial class VistaOP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaOP));
            this.btHermanado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbFec = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbOpNum = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbTurno = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pObservado = new System.Windows.Forms.Panel();
            this.defectoAgregarObs = new ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario.DefectoAgregar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbObservado = new System.Windows.Forms.Label();
            this.pReprocesado = new System.Windows.Forms.Panel();
            this.defectoAgregarRep = new ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario.DefectoAgregar();
            this.label9 = new System.Windows.Forms.Label();
            this.lbReprocesado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbHora = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbContadorPrimera = new System.Windows.Forms.Label();
            this.btnQuitarPar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarPar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label11 = new System.Windows.Forms.Label();
            this.Phermanado = new ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario.Hermanado();
            this.btSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btFiltrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btDeshacer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pObservado.SuspendLayout();
            this.pReprocesado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btHermanado
            // 
            this.btHermanado.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btHermanado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btHermanado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btHermanado.BorderRadius = 5;
            this.btHermanado.ButtonText = "Realizar Hermanado";
            this.btHermanado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHermanado.DisabledColor = System.Drawing.Color.Gray;
            this.btHermanado.Enabled = false;
            this.btHermanado.Iconcolor = System.Drawing.Color.Transparent;
            this.btHermanado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btHermanado.Iconimage")));
            this.btHermanado.Iconimage_right = null;
            this.btHermanado.Iconimage_right_Selected = null;
            this.btHermanado.Iconimage_Selected = null;
            this.btHermanado.IconMarginLeft = 0;
            this.btHermanado.IconMarginRight = 0;
            this.btHermanado.IconRightVisible = true;
            this.btHermanado.IconRightZoom = 0D;
            this.btHermanado.IconVisible = true;
            this.btHermanado.IconZoom = 90D;
            this.btHermanado.IsTab = false;
            this.btHermanado.Location = new System.Drawing.Point(517, 517);
            this.btHermanado.Margin = new System.Windows.Forms.Padding(4);
            this.btHermanado.Name = "btHermanado";
            this.btHermanado.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btHermanado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btHermanado.OnHoverTextColor = System.Drawing.Color.White;
            this.btHermanado.selected = false;
            this.btHermanado.Size = new System.Drawing.Size(233, 41);
            this.btHermanado.TabIndex = 32;
            this.btHermanado.Text = "Realizar Hermanado";
            this.btHermanado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHermanado.Textcolor = System.Drawing.Color.White;
            this.btHermanado.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHermanado.Click += new System.EventHandler(this.btHermanado_Click);
            // 
            // tbFec
            // 
            this.tbFec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.tbFec.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbFec.Enabled = false;
            this.tbFec.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbFec.ForeColor = System.Drawing.Color.White;
            this.tbFec.Location = new System.Drawing.Point(453, 29);
            this.tbFec.Name = "tbFec";
            this.tbFec.Size = new System.Drawing.Size(110, 27);
            this.tbFec.TabIndex = 29;
            // 
            // tbOpNum
            // 
            this.tbOpNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.tbOpNum.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbOpNum.Enabled = false;
            this.tbOpNum.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbOpNum.ForeColor = System.Drawing.Color.White;
            this.tbOpNum.Location = new System.Drawing.Point(154, 29);
            this.tbOpNum.Name = "tbOpNum";
            this.tbOpNum.Size = new System.Drawing.Size(110, 27);
            this.tbOpNum.TabIndex = 30;
            // 
            // tbTurno
            // 
            this.tbTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.tbTurno.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbTurno.Enabled = false;
            this.tbTurno.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbTurno.ForeColor = System.Drawing.Color.White;
            this.tbTurno.Location = new System.Drawing.Point(717, 29);
            this.tbTurno.Name = "tbTurno";
            this.tbTurno.Size = new System.Drawing.Size(110, 27);
            this.tbTurno.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(321, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "FECHA INICIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(42, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "OP ACTUAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(642, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "TURNO:";
            // 
            // pObservado
            // 
            this.pObservado.AutoScroll = true;
            this.pObservado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.pObservado.Controls.Add(this.defectoAgregarObs);
            this.pObservado.Controls.Add(this.label7);
            this.pObservado.Controls.Add(this.label6);
            this.pObservado.Controls.Add(this.lbObservado);
            this.pObservado.Location = new System.Drawing.Point(16, 118);
            this.pObservado.Name = "pObservado";
            this.pObservado.Size = new System.Drawing.Size(487, 392);
            this.pObservado.TabIndex = 33;
            // 
            // defectoAgregarObs
            // 
            this.defectoAgregarObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.defectoAgregarObs.Location = new System.Drawing.Point(3, 87);
            this.defectoAgregarObs.Name = "defectoAgregarObs";
            this.defectoAgregarObs.Size = new System.Drawing.Size(483, 70);
            this.defectoAgregarObs.TabIndex = 21;
            this.defectoAgregarObs.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(322, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Derecho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(57, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Izquierdo";
            // 
            // lbObservado
            // 
            this.lbObservado.AutoSize = true;
            this.lbObservado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbObservado.ForeColor = System.Drawing.Color.White;
            this.lbObservado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbObservado.Location = new System.Drawing.Point(165, 9);
            this.lbObservado.Name = "lbObservado";
            this.lbObservado.Size = new System.Drawing.Size(110, 21);
            this.lbObservado.TabIndex = 20;
            this.lbObservado.Text = "OBSERVADO";
            // 
            // pReprocesado
            // 
            this.pReprocesado.AutoScroll = true;
            this.pReprocesado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.pReprocesado.Controls.Add(this.defectoAgregarRep);
            this.pReprocesado.Controls.Add(this.label9);
            this.pReprocesado.Controls.Add(this.lbReprocesado);
            this.pReprocesado.Controls.Add(this.label8);
            this.pReprocesado.Location = new System.Drawing.Point(517, 118);
            this.pReprocesado.Name = "pReprocesado";
            this.pReprocesado.Size = new System.Drawing.Size(487, 392);
            this.pReprocesado.TabIndex = 34;
            // 
            // defectoAgregarRep
            // 
            this.defectoAgregarRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.defectoAgregarRep.Location = new System.Drawing.Point(3, 87);
            this.defectoAgregarRep.Name = "defectoAgregarRep";
            this.defectoAgregarRep.Size = new System.Drawing.Size(483, 70);
            this.defectoAgregarRep.TabIndex = 21;
            this.defectoAgregarRep.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(324, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Derecho";
            // 
            // lbReprocesado
            // 
            this.lbReprocesado.AutoSize = true;
            this.lbReprocesado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbReprocesado.ForeColor = System.Drawing.Color.White;
            this.lbReprocesado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReprocesado.Location = new System.Drawing.Point(165, 9);
            this.lbReprocesado.Name = "lbReprocesado";
            this.lbReprocesado.Size = new System.Drawing.Size(131, 21);
            this.lbReprocesado.TabIndex = 20;
            this.lbReprocesado.Text = "REPROCESADO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(59, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Izquierdo";
            // 
            // cbHora
            // 
            this.cbHora.BackColor = System.Drawing.Color.White;
            this.cbHora.ForeColor = System.Drawing.Color.White;
            this.cbHora.FormattingEnabled = true;
            this.cbHora.ItemHeight = 23;
            this.cbHora.Location = new System.Drawing.Point(154, 73);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(110, 29);
            this.cbHora.TabIndex = 35;
            this.cbHora.UseSelectable = true;
            this.cbHora.SelectedIndexChanged += new System.EventHandler(this.cbHora_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(86, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "HORA:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.lbContadorPrimera);
            this.panel1.Controls.Add(this.btnQuitarPar);
            this.panel1.Controls.Add(this.btnAgregarPar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(16, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 61);
            this.panel1.TabIndex = 34;
            // 
            // lbContadorPrimera
            // 
            this.lbContadorPrimera.AutoSize = true;
            this.lbContadorPrimera.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lbContadorPrimera.ForeColor = System.Drawing.Color.White;
            this.lbContadorPrimera.Location = new System.Drawing.Point(335, 22);
            this.lbContadorPrimera.Name = "lbContadorPrimera";
            this.lbContadorPrimera.Size = new System.Drawing.Size(21, 22);
            this.lbContadorPrimera.TabIndex = 32;
            this.lbContadorPrimera.Text = "0";
            // 
            // btnQuitarPar
            // 
            this.btnQuitarPar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnQuitarPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btnQuitarPar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitarPar.BackgroundImage")));
            this.btnQuitarPar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuitarPar.BorderRadius = 5;
            this.btnQuitarPar.ButtonText = "";
            this.btnQuitarPar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPar.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuitarPar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnQuitarPar.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuitarPar.Iconimage = null;
            this.btnQuitarPar.Iconimage_right = null;
            this.btnQuitarPar.Iconimage_right_Selected = null;
            this.btnQuitarPar.Iconimage_Selected = null;
            this.btnQuitarPar.IconMarginLeft = 0;
            this.btnQuitarPar.IconMarginRight = 0;
            this.btnQuitarPar.IconRightVisible = true;
            this.btnQuitarPar.IconRightZoom = 0D;
            this.btnQuitarPar.IconVisible = true;
            this.btnQuitarPar.IconZoom = 90D;
            this.btnQuitarPar.IsTab = false;
            this.btnQuitarPar.Location = new System.Drawing.Point(227, 13);
            this.btnQuitarPar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuitarPar.Name = "btnQuitarPar";
            this.btnQuitarPar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btnQuitarPar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnQuitarPar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuitarPar.selected = false;
            this.btnQuitarPar.Size = new System.Drawing.Size(40, 38);
            this.btnQuitarPar.TabIndex = 30;
            this.btnQuitarPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitarPar.Textcolor = System.Drawing.Color.White;
            this.btnQuitarPar.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPar.Click += new System.EventHandler(this.btnQuitarPar_Click);
            // 
            // btnAgregarPar
            // 
            this.btnAgregarPar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnAgregarPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btnAgregarPar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPar.BackgroundImage")));
            this.btnAgregarPar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarPar.BorderRadius = 5;
            this.btnAgregarPar.ButtonText = "";
            this.btnAgregarPar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarPar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAgregarPar.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarPar.Iconimage = null;
            this.btnAgregarPar.Iconimage_right = null;
            this.btnAgregarPar.Iconimage_right_Selected = null;
            this.btnAgregarPar.Iconimage_Selected = null;
            this.btnAgregarPar.IconMarginLeft = 0;
            this.btnAgregarPar.IconMarginRight = 0;
            this.btnAgregarPar.IconRightVisible = true;
            this.btnAgregarPar.IconRightZoom = 0D;
            this.btnAgregarPar.IconVisible = true;
            this.btnAgregarPar.IconZoom = 90D;
            this.btnAgregarPar.IsTab = false;
            this.btnAgregarPar.Location = new System.Drawing.Point(277, 13);
            this.btnAgregarPar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAgregarPar.Name = "btnAgregarPar";
            this.btnAgregarPar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btnAgregarPar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnAgregarPar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarPar.selected = false;
            this.btnAgregarPar.Size = new System.Drawing.Size(39, 38);
            this.btnAgregarPar.TabIndex = 29;
            this.btnAgregarPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarPar.Textcolor = System.Drawing.Color.White;
            this.btnAgregarPar.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPar.Click += new System.EventHandler(this.btnAgregarPar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(86, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "PAR PRIMERA";
            // 
            // Phermanado
            // 
            this.Phermanado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Phermanado.Location = new System.Drawing.Point(517, 565);
            this.Phermanado.Name = "Phermanado";
            this.Phermanado.Size = new System.Drawing.Size(382, 162);
            this.Phermanado.TabIndex = 36;
            // 
            // btSalir
            // 
            this.btSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalir.BorderRadius = 0;
            this.btSalir.ButtonText = "";
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btSalir.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btSalir.ForeColor = System.Drawing.Color.White;
            this.btSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btSalir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btSalir.Iconimage")));
            this.btSalir.Iconimage_right = null;
            this.btSalir.Iconimage_right_Selected = null;
            this.btSalir.Iconimage_Selected = null;
            this.btSalir.IconMarginLeft = 0;
            this.btSalir.IconMarginRight = 0;
            this.btSalir.IconRightVisible = true;
            this.btSalir.IconRightZoom = 0D;
            this.btSalir.IconVisible = true;
            this.btSalir.IconZoom = 60D;
            this.btSalir.IsTab = false;
            this.btSalir.Location = new System.Drawing.Point(924, 660);
            this.btSalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btSalir.Name = "btSalir";
            this.btSalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btSalir.selected = false;
            this.btSalir.Size = new System.Drawing.Size(61, 67);
            this.btSalir.TabIndex = 37;
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSalir.Textcolor = System.Drawing.Color.White;
            this.btSalir.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btFiltrar.BorderRadius = 5;
            this.btFiltrar.ButtonText = "Filtrar";
            this.btFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFiltrar.DisabledColor = System.Drawing.Color.Gray;
            this.btFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btFiltrar.ForeColor = System.Drawing.Color.White;
            this.btFiltrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btFiltrar.Iconimage = null;
            this.btFiltrar.Iconimage_right = null;
            this.btFiltrar.Iconimage_right_Selected = null;
            this.btFiltrar.Iconimage_Selected = null;
            this.btFiltrar.IconMarginLeft = 0;
            this.btFiltrar.IconMarginRight = 0;
            this.btFiltrar.IconRightVisible = true;
            this.btFiltrar.IconRightZoom = 0D;
            this.btFiltrar.IconVisible = true;
            this.btFiltrar.IconZoom = 90D;
            this.btFiltrar.IsTab = false;
            this.btFiltrar.Location = new System.Drawing.Point(272, 72);
            this.btFiltrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btFiltrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btFiltrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btFiltrar.selected = false;
            this.btFiltrar.Size = new System.Drawing.Size(82, 38);
            this.btFiltrar.TabIndex = 33;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btFiltrar.Textcolor = System.Drawing.Color.White;
            this.btFiltrar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // btDeshacer
            // 
            this.btDeshacer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btDeshacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btDeshacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDeshacer.BorderRadius = 5;
            this.btDeshacer.ButtonText = "Deshacer";
            this.btDeshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeshacer.DisabledColor = System.Drawing.Color.Gray;
            this.btDeshacer.Enabled = false;
            this.btDeshacer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btDeshacer.ForeColor = System.Drawing.Color.White;
            this.btDeshacer.Iconcolor = System.Drawing.Color.Transparent;
            this.btDeshacer.Iconimage = null;
            this.btDeshacer.Iconimage_right = null;
            this.btDeshacer.Iconimage_right_Selected = null;
            this.btDeshacer.Iconimage_Selected = null;
            this.btDeshacer.IconMarginLeft = 0;
            this.btDeshacer.IconMarginRight = 0;
            this.btDeshacer.IconRightVisible = true;
            this.btDeshacer.IconRightZoom = 0D;
            this.btDeshacer.IconVisible = true;
            this.btDeshacer.IconZoom = 90D;
            this.btDeshacer.IsTab = false;
            this.btDeshacer.Location = new System.Drawing.Point(364, 72);
            this.btDeshacer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btDeshacer.Name = "btDeshacer";
            this.btDeshacer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btDeshacer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btDeshacer.OnHoverTextColor = System.Drawing.Color.White;
            this.btDeshacer.selected = false;
            this.btDeshacer.Size = new System.Drawing.Size(94, 38);
            this.btDeshacer.TabIndex = 38;
            this.btDeshacer.Text = "Deshacer";
            this.btDeshacer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btDeshacer.Textcolor = System.Drawing.Color.White;
            this.btDeshacer.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeshacer.Click += new System.EventHandler(this.btDeshacer_Click);
            // 
            // VistaOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btDeshacer);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.Phermanado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.pReprocesado);
            this.Controls.Add(this.pObservado);
            this.Controls.Add(this.btHermanado);
            this.Controls.Add(this.tbFec);
            this.Controls.Add(this.tbOpNum);
            this.Controls.Add(this.tbTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Name = "VistaOP";
            this.Text = "VistaOP";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VistaOP_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VistaOP_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VistaOP_MouseUp);
            this.pObservado.ResumeLayout(false);
            this.pObservado.PerformLayout();
            this.pReprocesado.ResumeLayout(false);
            this.pReprocesado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btHermanado;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbFec;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbOpNum;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pObservado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbObservado;
        private System.Windows.Forms.Panel pReprocesado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbReprocesado;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroComboBox cbHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarPar;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuitarPar;
        private System.Windows.Forms.Label lbContadorPrimera;
        private ControladoresDeUsuario.Hermanado Phermanado;
        private Bunifu.Framework.UI.BunifuFlatButton btSalir;
        private ControladoresDeUsuario.DefectoAgregar defectoAgregarObs;
        private ControladoresDeUsuario.DefectoAgregar defectoAgregarRep;
        private Bunifu.Framework.UI.BunifuFlatButton btFiltrar;
        private Bunifu.Framework.UI.BunifuFlatButton btDeshacer;
    }
}