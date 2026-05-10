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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProductosVendidos
            // 
            this.buttonProductosVendidos.Location = new System.Drawing.Point(119, 215);
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
            this.dataGridViewReportes.Location = new System.Drawing.Point(415, 126);
            this.dataGridViewReportes.Name = "dataGridViewReportes";
            this.dataGridViewReportes.RowHeadersWidth = 51;
            this.dataGridViewReportes.RowTemplate.Height = 24;
            this.dataGridViewReportes.Size = new System.Drawing.Size(302, 218);
            this.dataGridViewReportes.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewReportes);
            this.Controls.Add(this.buttonProductosVendidos);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProductosVendidos;
        private System.Windows.Forms.DataGridView dataGridViewReportes;
    }
}