namespace labREPASO5
{
    partial class FormVehiculos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonVehiculos = new System.Windows.Forms.Button();
            this.dataGridViewVehiculos = new System.Windows.Forms.DataGridView();
            this.numericSueldoXkm = new System.Windows.Forms.NumericUpDown();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelPrecioKM = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSueldoXkm)).BeginInit();
            this.SuspendLayout();
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
            // numericSueldoXkm
            // 
            this.numericSueldoXkm.DecimalPlaces = 2;
            this.numericSueldoXkm.Location = new System.Drawing.Point(258, 222);
            this.numericSueldoXkm.Name = "numericSueldoXkm";
            this.numericSueldoXkm.Size = new System.Drawing.Size(161, 22);
            this.numericSueldoXkm.TabIndex = 7;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(258, 159);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(161, 22);
            this.textBoxColor.TabIndex = 6;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(258, 105);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(161, 22);
            this.textBoxModelo.TabIndex = 5;
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
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(80, 159);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(39, 16);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Color";
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
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.buttonVehiculos);
            this.Controls.Add(this.dataGridViewVehiculos);
            this.Controls.Add(this.numericSueldoXkm);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelPrecioKM);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.labelPlaca);
            this.Name = "FormVehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.FormVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSueldoXkm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonVehiculos;
        private System.Windows.Forms.DataGridView dataGridViewVehiculos;
        private System.Windows.Forms.NumericUpDown numericSueldoXkm;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelPrecioKM;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label labelPlaca;
    }
}
