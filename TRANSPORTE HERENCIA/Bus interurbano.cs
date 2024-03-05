using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_HERENCIA
{
    internal class Bus_interurbano : Transporte
    {
        public string Destino { get; set; }
        public string Compañia { get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine($"Destino: {Destino}");
            Console.WriteLine($"Compañia: {Compañia}");
        }
    }
}
