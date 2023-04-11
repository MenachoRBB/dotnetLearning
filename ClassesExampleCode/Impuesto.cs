using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public abstract class Impuesto
    {
        public double amount { get; set; }
        public abstract void Imprimir();

    }
}
