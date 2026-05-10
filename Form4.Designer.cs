namespace ProyectoPuntodeVenta
{
    partial class Form4
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
            this.buttonProductosVendidos = new System.Windows.Forms.Button();
            this.dataGridViewReportes = new System.Windows.Forms.DataGridView();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTotalVentas = new System.Windows.Forms.Button();
            this.buttonGanancia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProductosVendidos
            // 
            this.buttonProductosVendidos.Location = new System.Drawing.Point(108, 55);
            this.buttonProductosVendidos.Name = "buttonProductosVendidos";
            this.buttonProductosVendidos.Size = new System.Drawing.Size(142, 61);
            this.buttonProductosVendidos.TabIndex = 0;
            this.buttonProductosVendidos.Text = "Productos mas Vendidos";
            this.buttonProductosVendidos.UseVisualStyleBackColor = true;
            this.buttonProductosVendidos.Click += new System.EventHandler(this.buttonProductosVendidos_Click);
            // 
            // dataGridViewReportes
            // 
            this.dataGridViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportes.Location = new System.Drawing.Point(33, 147);
            this.dataGridViewReportes.Name = "dataGridViewReportes";
            this.dataGridViewReportes.RowHeadersWidth = 51;
            this.dataGridViewReportes.RowTemplate.Height = 24;
            this.dataGridViewReportes.Size = new System.Drawing.Size(302, 218);
            this.dataGridViewReportes.TabIndex = 1;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(560, 147);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(200, 22);
            this.dateTimeInicio.TabIndex = 2;
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Location = new System.Drawing.Point(560, 291);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFinal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fceha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Final";
            // 
            // buttonTotalVentas
            // 
            this.buttonTotalVentas.Location = new System.Drawing.Point(582, 370);
            this.buttonTotalVentas.Name = "buttonTotalVentas";
            this.buttonTotalVentas.Size = new System.Drawing.Size(118, 48);
            this.buttonTotalVentas.TabIndex = 6;
            this.buttonTotalVentas.Text = "Total de Ventas";
            this.buttonTotalVentas.UseVisualStyleBackColor = true;
            this.buttonTotalVentas.Click += new System.EventHandler(this.buttonTotalVentas_Click);
            // 
            // buttonGanancia
            // 
            this.buttonGanancia.Location = new System.Drawing.Point(786, 370);
            this.buttonGanancia.Name = "buttonGanancia";
            this.buttonGanancia.Size = new System.Drawing.Size(124, 48);
            this.buttonGanancia.TabIndex = 7;
            this.buttonGanancia.Text = "Ganacia entre Fechas";
            this.buttonGanancia.UseVisualStyleBackColor = true;
            this.buttonGanancia.Click += new System.EventHandler(this.buttonGanancia_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 533);
            this.Controls.Add(this.buttonGanancia);
            this.Controls.Add(this.buttonTotalVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.dataGridViewReportes);
            this.Controls.Add(this.buttonProductosVendidos);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProductosVendidos;
        private System.Windows.Forms.DataGridView dataGridViewReportes;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTotalVentas;
        private System.Windows.Forms.Button buttonGanancia;
    }
}