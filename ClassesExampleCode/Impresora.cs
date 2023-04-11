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
            Console.WriteLine($"Imprimiendo un documento {unDocumento.siglas} de {unDocumento.Total()}€ del día {unDocumento.date.ToShortDateString()}");
        }
        public void Imprimir(Factura unaFactura)
        {
            Console.WriteLine($"Imprimiendo una factura de {unaFactura.amount}€");
        }
        public void Imprimir(Albaran unAlbaran)
        {
            Console.WriteLine($"Imprimiendo un albarán con {unAlbaran.packageQuantity} bultos");

        }
        public void Imprimir(ReciboSueldo unReciboSueldo)
        {
            Console.WriteLine($"Imprimiendo un recibo de sueldo del legajo {unReciboSueldo.file}");

        }
        public void Imprimir(Municipal unMunicipal)
        {
            Console.WriteLine($"Imprimiendo el municipal de la partida {unMunicipal.partida}");

        }

        public void Imprimir(FacturaLuz unaFacturaLuz)
        {
            Console.WriteLine($"Imprimiendo una factura de luz de código de pago electrónico {unaFacturaLuz.payCode}");

        }
    }
}
