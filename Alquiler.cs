using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labREPASO5
{
    internal class Alquiler
    {
        string nit;
        string placa;
        DateTime fechainicio;
        DateTime fechafin;
        decimal kmrecorridos;

        public string Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }
        public decimal Kmrecorridos { get => kmrecorridos; set => kmrecorridos = value; }
    }
}
