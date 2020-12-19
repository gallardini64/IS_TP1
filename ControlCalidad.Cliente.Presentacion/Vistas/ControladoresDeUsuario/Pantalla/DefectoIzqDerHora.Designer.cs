
namespace ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario.Pantalla
{
    partial class DefectoIzqDerHora
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
            this.lbContIzq = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbContDer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbContIzq
            // 
            this.lbContIzq.AutoSize = true;
            this.lbContIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.lbContIzq.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbContIzq.ForeColor = System.Drawing.Color.White;
            this.lbContIzq.Location = new System.Drawing.Point(75, 9);
            this.lbContIzq.Name = "lbContIzq";
            this.lbContIzq.Size = new System.Drawing.Size(19, 21);
            this.lbContIzq.TabIndex = 47;
            this.lbContIzq.Text = "0";
            // 
            // lbContDer
            // 
            this.lbContDer.AutoSize = true;
            this.lbContDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.lbContDer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbContDer.ForeColor = System.Drawing.Color.White;
            this.lbContDer.Location = new System.Drawing.Point(19, 9);
            this.lbContDer.Name = "lbContDer";
            this.lbContDer.Size = new System.Drawing.Size(19, 21);
            this.lbContDer.TabIndex = 48;
            this.lbContDer.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.panel1.Location = new System.Drawing.Point(66, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 30);
            this.panel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 30);
            this.panel2.TabIndex = 50;
            // 
            // DefectoIzqDerHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.lbContIzq);
            this.Controls.Add(this.lbContDer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DefectoIzqDerHora";
            this.Size = new System.Drawing.Size(125, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbContIzq;
        private Bunifu.Framework.UI.BunifuCustomLabel lbContDer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
