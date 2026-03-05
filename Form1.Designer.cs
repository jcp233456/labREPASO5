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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonIngresoCliente = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNit = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPrecioKM = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.numericSueldoXkm = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewVehiculos = new System.Windows.Forms.DataGridView();
            this.buttonVehiculos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSueldoXkm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonIngresoCliente);
            this.tabPage1.Controls.Add(this.dataGridViewClientes);
            this.tabPage1.Controls.Add(this.textBoxDireccion);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.textBoxNit);
            this.tabPage1.Controls.Add(this.labelDireccion);
            this.tabPage1.Controls.Add(this.labelNombre);
            this.tabPage1.Controls.Add(this.labelNit);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonIngresoCliente
            // 
            this.buttonIngresoCliente.Location = new System.Drawing.Point(141, 333);
            this.buttonIngresoCliente.Name = "buttonIngresoCliente";
            this.buttonIngresoCliente.Size = new System.Drawing.Size(163, 39);
            this.buttonIngresoCliente.TabIndex = 7;
            this.buttonIngresoCliente.Text = "Ingresar Cliente";
            this.buttonIngresoCliente.UseVisualStyleBackColor = true;
            this.buttonIngresoCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(366, 40);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(557, 240);
            this.dataGridViewClientes.TabIndex = 6;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(141, 241);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(164, 22);
            this.textBoxDireccion.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(158, 144);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(164, 22);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(158, 40);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(164, 22);
            this.textBoxNit.TabIndex = 3;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(47, 247);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(64, 16);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(47, 147);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Location = new System.Drawing.Point(57, 46);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(29, 16);
            this.labelNit.TabIndex = 0;
            this.labelNit.Text = "NIT";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonVehiculos);
            this.tabPage2.Controls.Add(this.dataGridViewVehiculos);
            this.tabPage2.Controls.Add(this.numericSueldoXkm);
            this.tabPage2.Controls.Add(this.textBoxColor);
            this.tabPage2.Controls.Add(this.textBoxModelo);
            this.tabPage2.Controls.Add(this.labelPrecioKM);
            this.tabPage2.Controls.Add(this.labelColor);
            this.tabPage2.Controls.Add(this.labelModelo);
            this.tabPage2.Controls.Add(this.textBoxPlaca);
            this.tabPage2.Controls.Add(this.labelPlaca);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(988, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehiculos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(258, 48);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(161, 22);
            this.textBoxPlaca.TabIndex = 1;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(80, 48);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(42, 16);
            this.labelPlaca.TabIndex = 0;
            this.labelPlaca.Text = "Placa";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(951, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alquileres";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(80, 111);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(53, 16);
            this.labelModelo.TabIndex = 2;
            this.labelModelo.Text = "Modelo";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(80, 159);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(39, 16);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Color";
            // 
            // labelPrecioKM
            // 
            this.labelPrecioKM.AutoSize = true;
            this.labelPrecioKM.Location = new System.Drawing.Point(80, 222);
            this.labelPrecioKM.Name = "labelPrecioKM";
            this.labelPrecioKM.Size = new System.Drawing.Size(75, 16);
            this.labelPrecioKM.TabIndex = 4;
            this.labelPrecioKM.Text = "PrecioX km";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(258, 105);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(161, 22);
            this.textBoxModelo.TabIndex = 5;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(258, 159);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(161, 22);
            this.textBoxColor.TabIndex = 6;
            // 
            // numericSueldoXkm
            // 
            this.numericSueldoXkm.DecimalPlaces = 2;
            this.numericSueldoXkm.Location = new System.Drawing.Point(258, 222);
            this.numericSueldoXkm.Name = "numericSueldoXkm";
            this.numericSueldoXkm.Size = new System.Drawing.Size(161, 22);
            this.numericSueldoXkm.TabIndex = 7;
            // 
            // dataGridViewVehiculos
            // 
            this.dataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculos.Location = new System.Drawing.Point(460, 38);
            this.dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            this.dataGridViewVehiculos.RowHeadersWidth = 51;
            this.dataGridViewVehiculos.RowTemplate.Height = 24;
            this.dataGridViewVehiculos.Size = new System.Drawing.Size(500, 233);
            this.dataGridViewVehiculos.TabIndex = 8;
            // 
            // buttonVehiculos
            // 
            this.buttonVehiculos.Location = new System.Drawing.Point(396, 313);
            this.buttonVehiculos.Name = "buttonVehiculos";
            this.buttonVehiculos.Size = new System.Drawing.Size(184, 47);
            this.buttonVehiculos.TabIndex = 9;
            this.buttonVehiculos.Text = "Ingresar vehiculos";
            this.buttonVehiculos.UseVisualStyleBackColor = true;
            this.buttonVehiculos.Click += new System.EventHandler(this.buttonVehiculos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSueldoXkm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonIngresoCliente;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Button buttonVehiculos;
        private System.Windows.Forms.DataGridView dataGridViewVehiculos;
        private System.Windows.Forms.NumericUpDown numericSueldoXkm;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelPrecioKM;
    }
}

