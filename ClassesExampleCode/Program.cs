namespace ClassesExampleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UTF-8 configuration
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DocumentoContable unaFactura = new Factura()
            {
                amount = 1500
            };

            DocumentoContable unaNotaCredito = new NotaCredito()
            {
                amount = 1500
            };
            Albaran unAlbaran = new Albaran() 
            { 
                packageQuantity = 10
            };
            ReciboSueldo unRecibo = new ReciboSueldo()
            { 
                file = 2212
            };
            FacturaLuz unaFacturaLuz = new FacturaLuz()
            { 
                payCode = "162871687346"
            };    
            Municipal unMunicipal = new Municipal()
            { 
                partida = "SDFD 4378347-31823"
            };    

            Impresora unaImpresora = new Impresora();

            unaImpresora.Imprimir(unMunicipal);
            unaImpresora.Imprimir(unaFactura);
            unaImpresora.Imprimir(unaNotaCredito);

            unaImpresora.Imprimir(unRecibo);
            unaImpresora.Imprimir(unaFacturaLuz);
            unaImpresora.Imprimir(unAlbaran);

            Console.ReadKey();
        }
    }
}