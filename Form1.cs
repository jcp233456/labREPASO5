using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace labREPASO5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            FormVehiculos form = new FormVehiculos();
            form.Show();
        }

        private void btnAlquileres_Click(object sender, EventArgs e)
        {
            FormAlquiler form = new FormAlquiler();
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }
    }
}
