using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            string inicio;
            string fin;

            Console.WriteLine("Inserte numero de inicio");
            inicio = Console.ReadLine();
            Console.WriteLine("Inserte numero de fin");
            fin = Console.ReadLine();

            int A = Int32.Parse(inicio);
            int B = Int32.Parse(fin);
            
            Console.WriteLine();
            Console.WriteLine("Resultado:");
            for (int i = A; i<B; i++ )
            {
            Console.WriteLine(i);
            }
            
        }
    }
}
