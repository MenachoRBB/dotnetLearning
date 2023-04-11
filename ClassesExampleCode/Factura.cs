using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public class Factura : DocumentoContable
    {
        public Factura() 
        {
            _siglas = "FC - A";
        }
        public string siglas { get; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo desde Factura - {siglas} de {Total()}€ del dia {date.ToString("dd/MM/yyyy")}");
        }

        //Return amoun + IVA
        public override double Total()
        {
            return amount * 1.21;
        }


    }
}
