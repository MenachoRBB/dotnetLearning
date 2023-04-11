namespace ClassesExampleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UTF-8 configuration
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Construction of the objects
            IImprimible unaFactura = new Factura()
            {
                amount = 1500
            };

            IImprimible unaNotaCredito = new NotaCredito()
            {
                amount = 1500
            };
            IImprimible unAlbaran = new Albaran() 
            { 
                packageQuantity = 10
            };
            IImprimible unRecibo = new ReciboSueldo()
            { 
                file = 2212
            };
            IImprimible unaFacturaLuz = new FacturaLuz()
            { 
                payCode = "162871687346"
            };    
            IImprimible unMunicipal = new Municipal()
            { 
                partida = "SDFD 4378347-31823"
            };

            IImprimible unCoche = new Coche()
            {
                color = "Rojo",
                matricula = "0961-CBL"
            };

            //Construction of the printer
            Impresora unaImpresora = new Impresora();

            //Prints
            unaImpresora.Imprimir(unMunicipal);
            unaImpresora.Imprimir(unaFactura);
            unaImpresora.Imprimir(unaNotaCredito);

            unaImpresora.Imprimir(unRecibo);
            unaImpresora.Imprimir(unaFacturaLuz);
            unaImpresora.Imprimir(unAlbaran);
            unaImpresora.Imprimir(unCoche);

            Console.ReadKey();
        }
    }
}