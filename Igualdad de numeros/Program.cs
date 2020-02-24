using System;

namespace Igualdad_de_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B;

            Console.WriteLine("Inserte primer numero");
            A=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Inserte segundo numero");
            B=Int32.Parse(Console.ReadLine());

            if(A>B){
                Console.WriteLine("El primer numero es mayor que el segundo");
            }
            if(A<B){
                Console.WriteLine("El segundo numero es mayor que el primero");
            }
            if(A==B){
                Console.WriteLine("Los numeros son iguales");
            }


        }
    }
}
