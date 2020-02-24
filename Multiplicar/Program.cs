using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            string tabla,N1,N2;

            Console.WriteLine("Inserte tabla que desea");
            tabla = Console.ReadLine();
            Console.WriteLine("Inicio de tabla");
            N1 = Console.ReadLine();
            Console.WriteLine("Fin de tabla");
            N2 = Console.ReadLine();

            int tabl = Int32.Parse(tabla);
            int prim = Int32.Parse(N1);
            int segun =Int32.Parse(N2);
            int i;

            Console.WriteLine();
            Console.WriteLine("Resultado de la tabla");
            for(i=prim; i<=segun; i++){
            
            Console.WriteLine(tabla + " * " + i + " = " + (tabl * i));    
            }

        
            
        }
    }
}
