using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labREPASO5
{
    internal class Reporte
    {
        string nombre;
        string placa;
        string color;
        DateTime fechafin;
        decimal totalpagar;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Color { get => color; set => color = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }
        public decimal Totalpagar { get => totalpagar; set => totalpagar = value; }
    }
}
