using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public class Municipal : Impuesto
    {
        public double amount { get; set; }
        public string partida { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo el municipal de la partida {partida}");

        }
    }
}
