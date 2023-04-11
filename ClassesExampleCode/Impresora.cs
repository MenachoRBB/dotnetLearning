using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public class Impresora
    {

        public void Imprimir(IImprimible unElementoImprimible)
        {
            unElementoImprimible.Imprimir(); 
        }
    }
}
