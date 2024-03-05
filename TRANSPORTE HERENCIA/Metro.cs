using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_HERENCIA
{
    internal class Metro : Transporte
    {
        public string Compañia { get; set; }
        public string Linea { get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine($"Compañia: {Compañia}");
            Console.WriteLine($"Linea: {Linea}");
        }
    }
}
