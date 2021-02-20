using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingrese el monto de su venta: ");
            decimal monto = 0;
            decimal tasa = 20;
            decimal descuento = 0;
            decimal total = 0;
            if(Decimal.TryParse(Console.ReadLine(), out monto))
            {
                if (monto > 300)
                {
                    descuento =(monto * tasa) / 100;
                    total = monto - descuento;
                }
                Console.WriteLine("Su tiene un descuento del 20%");
                Console.WriteLine("Descuento: " + descuento);
                Console.WriteLine("Total a pagar: " + total);
            }
        }
    }
}
