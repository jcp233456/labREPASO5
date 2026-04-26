using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace labREPASO5
{
    public partial class FormReporte : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Reporte> reportes = new List<Reporte>();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            LeerClientes();
            LeerVehiculo();
            LeerAlquiler();
        }

        private void LeerClientes()
        {
            string fileName = "Clientes.txt";
            if (!File.Exists(fileName)) return;
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            clientes.Clear();
            while (reader.Peek() > -1)
            {
                Cliente leercliente = new Cliente();
                leercliente.Nit = reader.ReadLine();
                leercliente.Nombre = reader.ReadLine();
                leercliente.Direccion = reader.ReadLine();
                clientes.Add(leercliente);
            }
            reader.Close();
        }

        private void LeerVehiculo()
        {
            string fileName = "Vehiculos.txt";
            if (!File.Exists(fileName)) return;
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            vehiculos.Clear();
            while (reader.Peek() > -1)
            {
                Vehiculo leervehiculos = new Vehiculo();
                leervehiculos.Placa = reader.ReadLine();
                leervehiculos.Modelo = reader.ReadLine();
                leervehiculos.Color = reader.ReadLine();
                leervehiculos.PrecioXkm = Convert.ToDecimal(reader.ReadLine());
                vehiculos.Add(leervehiculos);
            }
            reader.Close();
        }

        private void LeerAlquiler()
        {
            string fileName = "Alquileres.txt";
            if (!File.Exists(fileName)) return;
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            alquileres.Clear();
            while (reader.Peek() > -1)
            {
                Alquiler leeralquiler = new Alquiler();
                leeralquiler.Nit = reader.ReadLine();
                leeralquiler.Placa = reader.ReadLine();
                leeralquiler.Fechainicio = Convert.ToDateTime(reader.ReadLine());
                leeralquiler.Fechafin = Convert.ToDateTime(reader.ReadLine());
                leeralquiler.Kmrecorridos = Convert.ToDecimal(reader.ReadLine());
                alquileres.Add(leeralquiler);
            }
            reader.Close();
        }

        private void MostrarReporte()
        {
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            reportes.Clear();
            foreach (var alquiler in alquileres)
            {
                Reporte reporte = new Reporte();
                foreach (var cliente in clientes)
                {
                    if (alquiler.Nit == cliente.Nit)
                    {
                        reporte.Nombre = cliente.Nombre;
                    }
                }
                foreach (var vehiculo in vehiculos)
                {
                    if (alquiler.Placa == vehiculo.Placa)
                    {
                        reporte.Placa = vehiculo.Placa;
                        reporte.Color = vehiculo.Color;
                        reporte.Fechafin = alquiler.Fechafin;
                        decimal Total = vehiculo.PrecioXkm * alquiler.Kmrecorridos;
                        reporte.Totalpagar = Total;
                    }
                }
                reportes.Add(reporte);
            }
            MostrarReporte();
        }
    }
}
