using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public class FacturaLuz : Impuesto
    {
        public string payCode { get; set; } 
        public double amount { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo una factura de luz de código de pago electrónico {payCode}");
        }
    }
}
