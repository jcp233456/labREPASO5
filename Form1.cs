using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labREPASO5
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
            LeerClientes();
        }

        private void GuardarCliente() {
            FileStream stream = new FileStream("Clientes.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in clientes)
            {
                writer.WriteLine(item.Nit);
                writer.WriteLine(item.Nombre);
                writer.WriteLine(item.Direccion);


            }
            writer.Close();
            mostrarCliente();

        }

        private void LeerClientes()
        {

            string fileName = "Clientes.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)

            {
                Cliente leercliente = new Cliente();
                leercliente.Nit = reader.ReadLine();
                leercliente.Nombre = reader.ReadLine();
                leercliente.Direccion = reader.ReadLine();


                clientes.Add(leercliente);
            }

            reader.Close();
            mostrarCliente();
        }

        private void mostrarCliente()
        {
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente newcliente = new Cliente();
            newcliente.Nit = textBoxNit.Text;
            newcliente.Nombre = textBoxNombre.Text;
            newcliente.Direccion = textBoxDireccion.Text;

            clientes.Add(newcliente);
            GuardarCliente();
            mostrarCliente();

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = textBoxPlaca.Text;
            vehiculo.Modelo = textBoxModelo.Text;
            vehiculo.Color = textBoxColor.Text;
            vehiculo.PrecioXkm = numericSueldoXkm.Value;

            vehiculos.Add(vehiculo);
            GuardarVehiculo();
            mostrarVehiculo();
        }


        private void GuardarVehiculo()
        {
            FileStream stream = new FileStream("Vehiculos.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in vehiculos)
            {
                writer.WriteLine(item.Placa);
                writer.WriteLine(item.Modelo);
                writer.WriteLine(item.Color);
                writer.WriteLine(item.PrecioXkm);



            }
            writer.Close();
            mostrarVehiculo();

        }
        private void mostrarVehiculo()
        {
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = vehiculos;
        }

        private void LeerVehiculo()
        {

            string fileName = "Vehiculos.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)

            {
                Vehiculo leervehiculos = new Vehiculo();
                leervehiculos.Placa = reader.ReadLine();
                leervehiculos.Modelo = reader.ReadLine();
                leervehiculos.Color = reader.ReadLine();
                leervehiculos.PrecioXkm = Convert.ToInt16(reader.ReadLine());


                vehiculos.Add(leervehiculos);
            }

            reader.Close();
            mostrarVehiculo();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerClientes();
            LeerVehiculo();
            LeerAlquiler();

            mostrarCliente();
            mostrarVehiculo();
            mostrarAlquiler();
        }

        private void buttonIngresoAlquileres_Click(object sender, EventArgs e)
        {

            Alquiler alquiler = new Alquiler();
            alquiler.Nit = textBoxNitAlquiler.Text;
            alquiler.Placa = textBoxPlacaAlquiler.Text;
            alquiler.Fechainicio = dateTimePickerFechaInicio.Value;
            alquiler.Fechafin = dateTimePickerFechaFin.Value;
            alquiler.Kmrecorridos = numericUpDownkmRecorridosAlquiler.Value;

            alquileres.Add(alquiler);
            GuardarAlquiler();
            mostrarAlquiler();

        }

        private void GuardarAlquiler()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in alquileres)
            {
                writer.WriteLine(item.Nit);
                writer.WriteLine(item.Placa);
                writer.WriteLine(item.Fechainicio);
                writer.WriteLine(item.Fechafin);
                writer.WriteLine(item.Kmrecorridos);



            }
            writer.Close();
            mostrarAlquiler();

        }

        private void mostrarAlquiler()
        {
            dataGridViewAlquiler.DataSource = null;
            dataGridViewAlquiler.DataSource = alquileres;
        }

        private void LeerAlquiler()
        {

            string fileName = "Alquileres.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)

            {
                Alquiler leeralquiler = new Alquiler();
                leeralquiler.Nit = reader.ReadLine();
                leeralquiler.Placa = reader.ReadLine();
                leeralquiler.Fechainicio = Convert.ToDateTime(reader.ReadLine());
                leeralquiler.Fechafin = Convert.ToDateTime(reader.ReadLine());
                leeralquiler.Kmrecorridos = Convert.ToInt16(reader.ReadLine());


                alquileres.Add(leeralquiler);
            }

            reader.Close();
            mostrarAlquiler();

        }

        private void MostrarReporte()
        {
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            //Un cilo que recorra todos los alquileres
            foreach (var alquiler in alquileres)
            {
                Reporte reporte = new Reporte();

                //Por cada alquiler que se lee, hay que buscar entre los clientes
                //quien tiene el NIT que alquilo, para encontrar su Nombre
                foreach (var cliente in clientes)
                {
                    if (alquiler.Nit == cliente.Nit)
                    {
                        reporte.Nombre = cliente.Nombre;
                    }
                }
                //Por cada alquiler que se lee, hay que buscar entre los vehículos
                //quien tiene la Placa del vehículo que se alquilo, para encontra
                //los datos de ese vehículo
                foreach (var vehiculo in vehiculos)
                {
                    if (alquiler.Placa == vehiculo.Placa)
                    {
                        reporte.Placa = vehiculo.Placa;
                        reporte.Color = vehiculo.Color;

                        reporte.Fechafin = alquiler.Fechafin;

                        //Aquí se calcula el Total a pagar
                        //El precio por vehículo esta en el Vehículo
                        //y los kilometros recorridos estan en el Alquiler
                        decimal Total = vehiculo.PrecioXkm * alquiler.Kmrecorridos;

                        reporte.Totalpagar = Total;
                    }
                }
                //Cada dato que se encontró se guardo en reporte
                //Entonces guardamos ese reporte en la lista de reportes
                reportes.Add(reporte);
            }
            MostrarReporte();

        }
    }
}
