using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_HERENCIA
{
    internal class Taxi : Transporte
    {
        public double Distancia { get; set; }

        public string Destino { get; set; }
        public double Tiempo { get; set; }

        public double Costo_total { get; set; }

        public double operar()
        {
            Costo_total = Distancia * Tiempo;
            return Costo_total;
        }

        public virtual void ImprimirDatos()
        {
            Console.WriteLine($"Destino: {Destino}");
            Console.WriteLine($"Tiempo: {Tiempo}");
            Console.WriteLine($"Costo_total: {Costo_total}");
        }
    }
}
