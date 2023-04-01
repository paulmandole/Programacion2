using System;
using Biblioteca;

namespace ClaseGenericsEjercicio_I02___Contabilidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recibo recibo1 = new Recibo();
            Factura factura1 = new Factura(123);
            Factura factura2 = new Factura(456);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            _ = contabilidad + recibo1;
            _ = contabilidad + factura1;
            _ = contabilidad + factura2;

            foreach (Documento item in contabilidad.egresos)
            {
                Console.WriteLine(item.Numero);
            }
            foreach (Documento item in contabilidad.ingresos)
            {
                Console.WriteLine(item.Numero);
            }
        }
    }
}
