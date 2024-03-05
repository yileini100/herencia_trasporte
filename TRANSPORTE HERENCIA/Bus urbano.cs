using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_HERENCIA
{
    internal class Bus_urbano : Transporte
    {
        public string Corredor { get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine($"corredor: {Corredor}");

        }
    }
}
