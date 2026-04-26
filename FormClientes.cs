using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace labREPASO5
{
    public partial class FormClientes : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            LeerClientes();
        }

        private void GuardarCliente()
        {
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
            mostrarCliente();
        }

        private void mostrarCliente()
        {
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientes;
        }

        private void buttonIngresoCliente_Click(object sender, EventArgs e)
        {
            Cliente newcliente = new Cliente();
            newcliente.Nit = textBoxNit.Text;
            newcliente.Nombre = textBoxNombre.Text;
            newcliente.Direccion = textBoxDireccion.Text;

            clientes.Add(newcliente);
            GuardarCliente();
            mostrarCliente();
        }
    }
}
