namespace ProyectoPuntodeVenta
{
    partial class Reportes
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
            this.dataGridViewReportes = new System.Windows.Forms.DataGridView();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.buttonPendientes = new System.Windows.Forms.Button();
            this.buttonEntregada = new System.Windows.Forms.Button();
            this.buttonTotalVentas = new System.Windows.Forms.Button();
            this.buttonGanancia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReportes
            // 
            this.dataGridViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportes.Location = new System.Drawing.Point(46, 54);
            this.dataGridViewReportes.Name = "dataGridViewReportes";
            this.dataGridViewReportes.RowHeadersWidth = 51;
            this.dataGridViewReportes.RowTemplate.Height = 24;
            this.dataGridViewReportes.Size = new System.Drawing.Size(298, 178);
            this.dataGridViewReportes.TabIndex = 0;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(738, 111);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(200, 22);
            this.dateTimeInicio.TabIndex = 1;
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Location = new System.Drawing.Point(738, 210);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFinal.TabIndex = 2;
            // 
            // buttonPendientes
            // 
            this.buttonPendientes.Location = new System.Drawing.Point(75, 387);
            this.buttonPendientes.Name = "buttonPendientes";
            this.buttonPendientes.Size = new System.Drawing.Size(75, 23);
            this.buttonPendientes.TabIndex = 3;
            this.buttonPendientes.Text = "button1";
            this.buttonPendientes.UseVisualStyleBackColor = true;
            this.buttonPendientes.Click += new System.EventHandler(this.buttonPendientes_Click);
            // 
            // buttonEntregada
            // 
            this.buttonEntregada.Location = new System.Drawing.Point(240, 386);
            this.buttonEntregada.Name = "buttonEntregada";
            this.buttonEntregada.Size = new System.Drawing.Size(75, 23);
            this.buttonEntregada.TabIndex = 4;
            this.buttonEntregada.Text = "button2";
            this.buttonEntregada.UseVisualStyleBackColor = true;
            this.buttonEntregada.Click += new System.EventHandler(this.buttonEntregada_Click);
            // 
            // buttonTotalVentas
            // 
            this.buttonTotalVentas.Location = new System.Drawing.Point(738, 375);
            this.buttonTotalVentas.Name = "buttonTotalVentas";
            this.buttonTotalVentas.Size = new System.Drawing.Size(75, 23);
            this.buttonTotalVentas.TabIndex = 5;
            this.buttonTotalVentas.Text = "button3";
            this.buttonTotalVentas.UseVisualStyleBackColor = true;
            this.buttonTotalVentas.Click += new System.EventHandler(this.buttonTotalVentas_Click);
            // 
            // buttonGanancia
            // 
            this.buttonGanancia.Location = new System.Drawing.Point(862, 375);
            this.buttonGanancia.Name = "buttonGanancia";
            this.buttonGanancia.Size = new System.Drawing.Size(75, 23);
            this.buttonGanancia.TabIndex = 6;
            this.buttonGanancia.Text = "button4";
            this.buttonGanancia.UseVisualStyleBackColor = true;
            this.buttonGanancia.Click += new System.EventHandler(this.buttonGanancia_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 533);
            this.Controls.Add(this.buttonGanancia);
            this.Controls.Add(this.buttonTotalVentas);
            this.Controls.Add(this.buttonEntregada);
            this.Controls.Add(this.buttonPendientes);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.dataGridViewReportes);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReportes;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.Button buttonPendientes;
        private System.Windows.Forms.Button buttonEntregada;
        private System.Windows.Forms.Button buttonTotalVentas;
        private System.Windows.Forms.Button buttonGanancia;
    }
}