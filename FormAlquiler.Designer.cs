namespace labREPASO5
{
    partial class FormAlquiler
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
            this.numericUpDownkmRecorridosAlquiler = new System.Windows.Forms.NumericUpDown();
            this.buttonIngresoAlquileres = new System.Windows.Forms.Button();
            this.dataGridViewAlquiler = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.textBoxPlacaAlquiler = new System.Windows.Forms.TextBox();
            this.textBoxNitAlquiler = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkmRecorridosAlquiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownkmRecorridosAlquiler
            // 
            this.numericUpDownkmRecorridosAlquiler.Location = new System.Drawing.Point(197, 296);
            this.numericUpDownkmRecorridosAlquiler.Name = "numericUpDownkmRecorridosAlquiler";
            this.numericUpDownkmRecorridosAlquiler.Size = new System.Drawing.Size(195, 22);
            this.numericUpDownkmRecorridosAlquiler.TabIndex = 13;
            // 
            // buttonIngresoAlquileres
            // 
            this.buttonIngresoAlquileres.Location = new System.Drawing.Point(358, 342);
            this.buttonIngresoAlquileres.Name = "buttonIngresoAlquileres";
            this.buttonIngresoAlquileres.Size = new System.Drawing.Size(255, 59);
            this.buttonIngresoAlquileres.TabIndex = 12;
            this.buttonIngresoAlquileres.Text = "Ingresar Alquiler";
            this.buttonIngresoAlquileres.UseVisualStyleBackColor = true;
            this.buttonIngresoAlquileres.Click += new System.EventHandler(this.buttonIngresoAlquileres_Click);
            // 
            // dataGridViewAlquiler
            // 
            this.dataGridViewAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquiler.Location = new System.Drawing.Point(551, 41);
            this.dataGridViewAlquiler.Name = "dataGridViewAlquiler";
            this.dataGridViewAlquiler.RowHeadersWidth = 51;
            this.dataGridViewAlquiler.RowTemplate.Height = 24;
            this.dataGridViewAlquiler.Size = new System.Drawing.Size(406, 249);
            this.dataGridViewAlquiler.TabIndex = 11;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(188, 217);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(269, 22);
            this.dateTimePickerFechaFin.TabIndex = 9;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(197, 168);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(269, 22);
            this.dateTimePickerFechaInicio.TabIndex = 8;
            // 
            // textBoxPlacaAlquiler
            // 
            this.textBoxPlacaAlquiler.Location = new System.Drawing.Point(188, 101);
            this.textBoxPlacaAlquiler.Name = "textBoxPlacaAlquiler";
            this.textBoxPlacaAlquiler.Size = new System.Drawing.Size(144, 22);
            this.textBoxPlacaAlquiler.TabIndex = 7;
            // 
            // textBoxNitAlquiler
            // 
            this.textBoxNitAlquiler.Location = new System.Drawing.Point(188, 41);
            this.textBoxNitAlquiler.Name = "textBoxNitAlquiler";
            this.textBoxNitAlquiler.Size = new System.Drawing.Size(144, 22);
            this.textBoxNitAlquiler.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "km recorridos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha devolucion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha alquiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.numericUpDownkmRecorridosAlquiler);
            this.Controls.Add(this.buttonIngresoAlquileres);
            this.Controls.Add(this.dataGridViewAlquiler);
            this.Controls.Add(this.dateTimePickerFechaFin);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.textBoxPlacaAlquiler);
            this.Controls.Add(this.textBoxNitAlquiler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.FormAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkmRecorridosAlquiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown numericUpDownkmRecorridosAlquiler;
        private System.Windows.Forms.Button buttonIngresoAlquileres;
        private System.Windows.Forms.DataGridView dataGridViewAlquiler;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.TextBox textBoxPlacaAlquiler;
        private System.Windows.Forms.TextBox textBoxNitAlquiler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
