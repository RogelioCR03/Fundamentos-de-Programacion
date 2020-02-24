using System;

namespace Arreglos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] A = {{1,0,0,0},{0,1,0,0},{0,0,1,0},{0,0,0,1}};

            for (int i=0; i<4; i++)
            {
                for (int j=0; j<4; j++)
                {
                    Console.Write(A[j,i]+"\t");
                }
               Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
