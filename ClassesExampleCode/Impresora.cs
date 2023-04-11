using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExampleCode
{
    public class Impresora
    {

        public void Imprimir(DocumentoContable unDocumento)
        {
            unDocumento.Imprimir(); 
        }
        public void Imprimir(Albaran unAlbaran)
        {
            unAlbaran.Imprimir();

        }
        public void Imprimir(ReciboSueldo unReciboSueldo)
        {
            unReciboSueldo.Imprimir();  
        }
        public void Imprimir(Impuesto unImpuesto)
        {
            unImpuesto.Imprimir();
        }
    }
}
