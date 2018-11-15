namespace GimenaSanchezIIParcial
{
    partial class frmPrincipal
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
            this.btnIngresarCanciones = new System.Windows.Forms.Button();
            this.btnEliminarcanciones = new System.Windows.Forms.Button();
            this.btnReporteCanciones = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarCanciones
            // 
            this.btnIngresarCanciones.Location = new System.Drawing.Point(32, 23);
            this.btnIngresarCanciones.Name = "btnIngresarCanciones";
            this.btnIngresarCanciones.Size = new System.Drawing.Size(205, 23);
            this.btnIngresarCanciones.TabIndex = 0;
            this.btnIngresarCanciones.Text = "Ingresar Nuevas Canciones";
            this.btnIngresarCanciones.UseVisualStyleBackColor = true;
            this.btnIngresarCanciones.Click += new System.EventHandler(this.btnIngresarCanciones_Click);
            // 
            // btnEliminarcanciones
            // 
            this.btnEliminarcanciones.Location = new System.Drawing.Point(32, 52);
            this.btnEliminarcanciones.Name = "btnEliminarcanciones";
            this.btnEliminarcanciones.Size = new System.Drawing.Size(205, 23);
            this.btnEliminarcanciones.TabIndex = 1;
            this.btnEliminarcanciones.Text = "Eliminar Canciones Existentes";
            this.btnEliminarcanciones.UseVisualStyleBackColor = true;
            this.btnEliminarcanciones.Click += new System.EventHandler(this.btnEliminarcanciones_Click);
            // 
            // btnReporteCanciones
            // 
            this.btnReporteCanciones.Location = new System.Drawing.Point(32, 81);
            this.btnReporteCanciones.Name = "btnReporteCanciones";
            this.btnReporteCanciones.Size = new System.Drawing.Size(205, 23);
            this.btnReporteCanciones.TabIndex = 2;
            this.btnReporteCanciones.Text = "Ver Reporte de Canciones";
            this.btnReporteCanciones.UseVisualStyleBackColor = true;
            this.btnReporteCanciones.Click += new System.EventHandler(this.btnReporteCanciones_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(32, 170);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(205, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporteCanciones);
            this.Controls.Add(this.btnEliminarcanciones);
            this.Controls.Add(this.btnIngresarCanciones);
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarCanciones;
        private System.Windows.Forms.Button btnEliminarcanciones;
        private System.Windows.Forms.Button btnReporteCanciones;
        private System.Windows.Forms.Button btnSalir;
    }
}

