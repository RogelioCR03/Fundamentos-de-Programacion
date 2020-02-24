using System;

namespace Ejercicio_arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            string [] nombres;
            string [] edad;
            nombres = new string [5];
            edad = new string [5];

            for(i=0; i<5; i++){
             Console.WriteLine("Ingrese nombre");
             nombres [i] = Console.ReadLine();
             }

            for (j=0; j<5; j++){
             Console.WriteLine("Ingrese edad");
             edad [j] = Console.ReadLine();
            }
        }
    }
}
