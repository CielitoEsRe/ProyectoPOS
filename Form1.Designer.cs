namespace ProyectoPuntodeVenta
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTrastienda = new System.Windows.Forms.Button();
            this.buttonPuntodeVenta = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTrastienda
            // 
            this.buttonTrastienda.Location = new System.Drawing.Point(94, 179);
            this.buttonTrastienda.Name = "buttonTrastienda";
            this.buttonTrastienda.Size = new System.Drawing.Size(147, 89);
            this.buttonTrastienda.TabIndex = 0;
            this.buttonTrastienda.Text = "Trastienda";
            this.buttonTrastienda.UseVisualStyleBackColor = true;
            this.buttonTrastienda.Click += new System.EventHandler(this.buttonTrastienda_Click);
            // 
            // buttonPuntodeVenta
            // 
            this.buttonPuntodeVenta.Location = new System.Drawing.Point(330, 182);
            this.buttonPuntodeVenta.Name = "buttonPuntodeVenta";
            this.buttonPuntodeVenta.Size = new System.Drawing.Size(136, 86);
            this.buttonPuntodeVenta.TabIndex = 1;
            this.buttonPuntodeVenta.Text = "Punto de Venta";
            this.buttonPuntodeVenta.UseVisualStyleBackColor = true;
            this.buttonPuntodeVenta.Click += new System.EventHandler(this.buttonPuntodeVenta_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.ForeColor = System.Drawing.Color.Black;
            this.buttonReportes.Location = new System.Drawing.Point(549, 182);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(128, 86);
            this.buttonReportes.TabIndex = 2;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Principal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.buttonPuntodeVenta);
            this.Controls.Add(this.buttonTrastienda);
            this.Name = "Form1";
            this.Text = "Sistema POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrastienda;
        private System.Windows.Forms.Button buttonPuntodeVenta;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Label label1;
    }
}

