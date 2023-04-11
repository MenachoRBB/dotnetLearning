using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    //Just a test for see that we can add any object
    internal class Coche : IImprimible
    {
        public string matricula { get; set; }
        public string color { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo un coche de color {color} con matricula {matricula}");
        }
    }
}
