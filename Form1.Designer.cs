namespace labREPASO5
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnAlquileres = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(100, 50);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 50);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Gestionar Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Location = new System.Drawing.Point(100, 120);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(200, 50);
            this.btnVehiculos.TabIndex = 1;
            this.btnVehiculos.Text = "Gestionar Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnAlquileres
            // 
            this.btnAlquileres.Location = new System.Drawing.Point(100, 190);
            this.btnAlquileres.Name = "btnAlquileres";
            this.btnAlquileres.Size = new System.Drawing.Size(200, 50);
            this.btnAlquileres.TabIndex = 2;
            this.btnAlquileres.Text = "Gestionar Alquileres";
            this.btnAlquileres.UseVisualStyleBackColor = true;
            this.btnAlquileres.Click += new System.EventHandler(this.btnAlquileres_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(100, 260);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 50);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Ver Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVehiculos);
            this.Controls.Add(this.btnAlquileres);
            this.Controls.Add(this.btnReportes);
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnAlquileres;
        private System.Windows.Forms.Button btnReportes;
    }
}

