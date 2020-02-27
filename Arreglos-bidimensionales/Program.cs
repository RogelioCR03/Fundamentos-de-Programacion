using System;

namespace Arreglos_bidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] A = new int [4,4];

            for (int i=0; i<4; i++)
            {
             for (int j=0; j<4; j++)
             {
              if (i==j){
                  Console.Write("1"+"\t");
              }
              if (i<j){
                  Console.Write("0"+"\t");
              }
              if (i>j){
                  Console.Write("0"+"\t");
              }
             }
             Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
