using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese una letra");
            String letra = Console.ReadLine();
            if (Char.IsUpper(letra, 0))
            {
                Console.WriteLine("Es mayuscula");
            }
            else
            {
                Console.WriteLine("Es minuscula");
            }
        }
    }
}
