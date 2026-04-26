using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace labREPASO5
{
    public partial class FormVehiculos : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public FormVehiculos()
        {
            InitializeComponent();
        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            LeerVehiculo();
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
            mostrarVehiculo();
        }
    }
}
