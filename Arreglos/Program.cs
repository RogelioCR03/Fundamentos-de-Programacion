using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string [] nombres;
            nombres = new string [4];

            Console.WriteLine("Ingrese 4 nombres");
            for(i=0; i<4; i++){
             nombres [i] = Console.ReadLine();
            }
            
            Console.WriteLine();
            
            Console.WriteLine("Nombres Ingresados:");
            for(i=0; i<4; i++){
            Console.WriteLine(nombres [i]);
            }
        }
    }
}
