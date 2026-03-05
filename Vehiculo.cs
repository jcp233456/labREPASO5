using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labREPASO5
{
    internal class Vehiculo
    {
        string placa;
        string modelo;
        string color;
        decimal precioXkm;

        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public decimal PrecioXkm { get => precioXkm; set => precioXkm = value; }
    }
}
