using System;

namespace Struct
{
    class Program
    {
        struct tipoPersona
        {
            public string nombre;
            public int edad;
        }
        static void Main(string[] args)
        {
            tipoPersona[] personas = new tipoPersona [5];
            int i;
            
            for (i=0; i<5; i++){
                Console.WriteLine("Ingrese nombre");
            personas [i].nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            personas [i].edad = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Datos Ingresados:");
            for (i=0; i<5; i++){
            Console.WriteLine(personas [i].nombre + " " + personas [i].edad);
            }
        }
    }
}
