using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_HERENCIA
{
    internal class Transporte
    {
        public double Costo { get; set; }

        public virtual void ImprimirDatos()
        {
            Console.WriteLine($"Costo: {Costo}");
        }
    }
}
