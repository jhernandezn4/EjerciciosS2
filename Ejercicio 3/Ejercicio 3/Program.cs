using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, normal, extras;
            decimal sueldo;
            Console.WriteLine("Ingrese sus horas trabajadas");
            horas = int.Parse(Console.ReadLine());
            extras = horas - 40;
            if (extras < 0)
            {
                extras = 0;
            }
            normal = horas - extras;
            sueldo = (normal * 16) + (extras * 20);

            Console.WriteLine("Su sueldo es el siguiente");
            Console.WriteLine("Horas normales a Q16 la hora: " + normal);
            Console.WriteLine("Horas extras a Q20 la hora: " + extras);
            Console.WriteLine("Su sueldo es de: "+sueldo);

        }
    }
}
