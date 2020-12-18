
namespace ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario.Pantalla
{
    partial class IzquierdaDerechaPorHora
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbHora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbizq = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(62, 3);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(59, 30);
            this.lbHora.TabIndex = 45;
            this.lbHora.Text = "0:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.panel2.Location = new System.Drawing.Point(8, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 37);
            this.panel2.TabIndex = 46;
            // 
            // lbizq
            // 
            this.lbizq.AutoSize = true;
            this.lbizq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.lbizq.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbizq.ForeColor = System.Drawing.Color.White;
            this.lbizq.Location = new System.Drawing.Point(20, 39);
            this.lbizq.Name = "lbizq";
            this.lbizq.Size = new System.Drawing.Size(52, 30);
            this.lbizq.TabIndex = 45;
            this.lbizq.Text = "IZQ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.panel1.Location = new System.Drawing.Point(90, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 37);
            this.panel1.TabIndex = 46;
            // 
            // lbDer
            // 
            this.lbDer.AutoSize = true;
            this.lbDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.lbDer.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbDer.ForeColor = System.Drawing.Color.White;
            this.lbDer.Location = new System.Drawing.Point(99, 39);
            this.lbDer.Name = "lbDer";
            this.lbDer.Size = new System.Drawing.Size(59, 30);
            this.lbDer.TabIndex = 45;
            this.lbDer.Text = "DER";
            // 
            // IzquierdaDerechaPorHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.lbDer);
            this.Controls.Add(this.lbizq);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "IzquierdaDerechaPorHora";
            this.Size = new System.Drawing.Size(175, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbHora;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbizq;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDer;
    }
}
