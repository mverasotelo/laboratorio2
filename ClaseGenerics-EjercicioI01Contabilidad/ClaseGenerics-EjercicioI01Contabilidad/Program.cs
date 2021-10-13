using System;
using Biblioteca;

namespace ClaseGenerics_EjercicioI01Contabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> cont = new Contabilidad<Factura, Recibo>();
            Factura f1 = new Factura(15454);
            Factura f2 = new Factura(54545);
            Factura f3 = new Factura(545455);
            Factura f4 = new Factura(78788);

            _ = cont + f1;
            _ = cont + f2;
            _ = cont + f3;
            _ = cont + f4;

            Recibo r1 = new Recibo(48789);
            Recibo r2 = new Recibo(47275);
            Recibo r3 = new Recibo(466789);
            Recibo r4 = new Recibo(5876758);

            _ = cont + r1;
            _ = cont + r2;
            _ = cont + r3;
            _ = cont + r4;

            foreach(Recibo r in cont.ingresos)
            {
                Console.WriteLine($"Recibo N°{r.numero}");
            }

            Console.WriteLine();

            foreach (Factura f in cont.egresos)
            {
                Console.WriteLine($"Factura N°{f.numero}");
            }
        }
    }
}
