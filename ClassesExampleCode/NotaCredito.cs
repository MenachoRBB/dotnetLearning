using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public class NotaCredito : DocumentoContable
    {

        public NotaCredito() 
        {
            _siglas = "NC - A";
        }
        public string siglas { get; }

        //Return amount + IVA in negative
        public override double Total()
        {
            return amount * 1.21 * -1;
        }

    }
}

