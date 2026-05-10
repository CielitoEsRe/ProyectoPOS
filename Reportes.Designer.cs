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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReportes
            // 
            this.dataGridViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportes.Location = new System.Drawing.Point(47, 111);
            this.dataGridViewReportes.Name = "dataGridViewReportes";
            this.dataGridViewReportes.RowHeadersWidth = 51;
            this.dataGridViewReportes.RowTemplate.Height = 24;
            this.dataGridViewReportes.Size = new System.Drawing.Size(415, 233);
            this.dataGridViewReportes.TabIndex = 0;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(738, 139);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(200, 22);
            this.dateTimeInicio.TabIndex = 1;
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Location = new System.Drawing.Point(738, 267);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFinal.TabIndex = 2;
            // 
            // buttonPendientes
            // 
            this.buttonPendientes.Location = new System.Drawing.Point(75, 387);
            this.buttonPendientes.Name = "buttonPendientes";
            this.buttonPendientes.Size = new System.Drawing.Size(110, 63);
            this.buttonPendientes.TabIndex = 3;
            this.buttonPendientes.Text = "Ver Ventas Pendientes";
            this.buttonPendientes.UseVisualStyleBackColor = true;
            this.buttonPendientes.Click += new System.EventHandler(this.buttonPendientes_Click);
            // 
            // buttonEntregada
            // 
            this.buttonEntregada.Location = new System.Drawing.Point(266, 386);
            this.buttonEntregada.Name = "buttonEntregada";
            this.buttonEntregada.Size = new System.Drawing.Size(105, 64);
            this.buttonEntregada.TabIndex = 4;
            this.buttonEntregada.Text = "Modificar a Venta Entregada";
            this.buttonEntregada.UseVisualStyleBackColor = true;
            this.buttonEntregada.Click += new System.EventHandler(this.buttonEntregada_Click);
            // 
            // buttonTotalVentas
            // 
            this.buttonTotalVentas.Location = new System.Drawing.Point(718, 375);
            this.buttonTotalVentas.Name = "buttonTotalVentas";
            this.buttonTotalVentas.Size = new System.Drawing.Size(113, 56);
            this.buttonTotalVentas.TabIndex = 5;
            this.buttonTotalVentas.Text = "Ver Total de Ventas";
            this.buttonTotalVentas.UseVisualStyleBackColor = true;
            this.buttonTotalVentas.Click += new System.EventHandler(this.buttonTotalVentas_Click);
            // 
            // buttonGanancia
            // 
            this.buttonGanancia.Location = new System.Drawing.Point(874, 375);
            this.buttonGanancia.Name = "buttonGanancia";
            this.buttonGanancia.Size = new System.Drawing.Size(105, 56);
            this.buttonGanancia.TabIndex = 6;
            this.buttonGanancia.Text = "Ver Ganancias";
            this.buttonGanancia.UseVisualStyleBackColor = true;
            this.buttonGanancia.Click += new System.EventHandler(this.buttonGanancia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de Incio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de Finalización:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ventas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Regresar al Menú Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReportes;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.Button buttonPendientes;
        private System.Windows.Forms.Button buttonEntregada;
        private System.Windows.Forms.Button buttonTotalVentas;
        private System.Windows.Forms.Button buttonGanancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}