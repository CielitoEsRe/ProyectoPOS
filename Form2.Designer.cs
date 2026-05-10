namespace ProyectoPuntodeVenta
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGuardarProducto = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textPrecioCompra = new System.Windows.Forms.TextBox();
            this.textPrecioVenta = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.buttonActualizarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad en Existencia:";
            // 
            // buttonGuardarProducto
            // 
            this.buttonGuardarProducto.Location = new System.Drawing.Point(133, 461);
            this.buttonGuardarProducto.Name = "buttonGuardarProducto";
            this.buttonGuardarProducto.Size = new System.Drawing.Size(144, 53);
            this.buttonGuardarProducto.TabIndex = 6;
            this.buttonGuardarProducto.Text = "Guardar Producto";
            this.buttonGuardarProducto.UseVisualStyleBackColor = true;
            this.buttonGuardarProducto.Click += new System.EventHandler(this.buttonGuardarProducto_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(664, 96);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(311, 337);
            this.dataGridViewProductos.TabIndex = 7;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(117, 82);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(260, 22);
            this.textCodigo.TabIndex = 8;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(122, 149);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(255, 22);
            this.textNombre.TabIndex = 9;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(108, 210);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(269, 22);
            this.textMarca.TabIndex = 10;
            // 
            // textPrecioCompra
            // 
            this.textPrecioCompra.Location = new System.Drawing.Point(185, 273);
            this.textPrecioCompra.Name = "textPrecioCompra";
            this.textPrecioCompra.Size = new System.Drawing.Size(192, 22);
            this.textPrecioCompra.TabIndex = 11;
            // 
            // textPrecioVenta
            // 
            this.textPrecioVenta.Location = new System.Drawing.Point(175, 330);
            this.textPrecioVenta.Name = "textPrecioVenta";
            this.textPrecioVenta.Size = new System.Drawing.Size(202, 22);
            this.textPrecioVenta.TabIndex = 12;
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(215, 375);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(162, 22);
            this.textCantidad.TabIndex = 13;
            // 
            // buttonActualizarProducto
            // 
            this.buttonActualizarProducto.Location = new System.Drawing.Point(329, 461);
            this.buttonActualizarProducto.Name = "buttonActualizarProducto";
            this.buttonActualizarProducto.Size = new System.Drawing.Size(128, 53);
            this.buttonActualizarProducto.TabIndex = 14;
            this.buttonActualizarProducto.Text = "ActualizarProducto";
            this.buttonActualizarProducto.UseVisualStyleBackColor = true;
            this.buttonActualizarProducto.Click += new System.EventHandler(this.buttonActualizarProducto_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 564);
            this.Controls.Add(this.buttonActualizarProducto);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textPrecioVenta);
            this.Controls.Add(this.textPrecioCompra);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.buttonGuardarProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGuardarProducto;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textPrecioCompra;
        private System.Windows.Forms.TextBox textPrecioVenta;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Button buttonActualizarProducto;
    }
}