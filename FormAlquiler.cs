using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace labREPASO5
{
    public partial class FormAlquiler : Form
    {
        List<Alquiler> alquileres = new List<Alquiler>();

        public FormAlquiler()
        {
            InitializeComponent();
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            LeerAlquiler();
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
            mostrarAlquiler();
        }
    }
}
