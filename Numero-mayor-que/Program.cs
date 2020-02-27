using System;

namespace Numero_mayor_que
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumA;
            string NumB;

            Console.WriteLine("Inserte el numero A:");
            NumA = Console.ReadLine();
            Console.WriteLine("Inserte el numero B:");
            NumB = Console.ReadLine();

            int A = Int32.Parse(NumA);
            int B = Int32.Parse(NumB);

            Console.WriteLine();
            Console.WriteLine("Resultado =");
            if (A > B) Console.WriteLine(NumA + " es mayor que " + NumB);
            if (B > A) Console.WriteLine(NumB + " es mayor que " + NumA);

        }
    }
}
