using System;

namespace Nueva_carpeta
{
    class Program
    {
        static void Main(string[] args)
        {   
            string Nombre;
            string Edad;
            string SalarBase;
            string Comis;

            Console.WriteLine("Registro de nuevo empleado");
            Console.WriteLine("Nombre del empleado");
            Nombre = Console.ReadLine();
            Console.WriteLine("Edad");
            Edad = Console.ReadLine();
            Console.WriteLine("Inserte Salario Base");
            SalarBase = Console.ReadLine();
            Console.WriteLine("Comision del Empleado");
            Comis = Console.ReadLine();

            int A = Int32.Parse(SalarBase);
            int B = Int32.Parse(Comis);
            
            Console.WriteLine();
            Console.WriteLine("Datos del nuevo empleado:");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Salario Base: " + SalarBase);
            Console.WriteLine("Comisiones: " + Comis);
            Console.WriteLine("Sueldo Neto: " + (A+B) / 1.11);

        }
    }
}
