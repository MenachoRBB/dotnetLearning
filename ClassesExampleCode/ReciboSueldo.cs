using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public class ReciboSueldo : IImprimible
    {
        public int file { get; set; }
        public double total { get; set; }  

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo un recibo de sueldo del legajo {file}");

        }
    }
}
