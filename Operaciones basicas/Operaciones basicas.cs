using System;

namespace Operaciones_basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            string y;

            Console.WriteLine("Ingresar numero");
            x = Console.ReadLine();
            Console.WriteLine("Insertar numero");
            y = Console.ReadLine();

            int a = Int32.Parse(x);
            int b = Int32.Parse(y);

            Console.WriteLine();
            Console.WriteLine("Resultado Suma = " + (a+b));
            
            Console.WriteLine("Resultado Resta = " + (a-b));
            
            Console.WriteLine("Resultado Multiplicacion = " + (a*b));
            
        }
    }
}
