using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public class Albaran : IImprimible
    {
        public int packageQuantity { get; set; }
        public DateTime date { get; set; }
        public int number { get; set; }
        public double amount { get; set; }
        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo un albaran con {packageQuantity} bultos");
        }
    }
}
