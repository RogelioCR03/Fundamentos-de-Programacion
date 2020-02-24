using System;

namespace Static Void
{
    class Program
    {
        static void Main(string[] args)
        {
            captura("Rogelio");
            int resultado;
            resultado = sumn(5,6);
            Console.WriteLine(resultado + 5);
        }
        static void captura(string name)
        {
            Console.WriteLine("Hola, mi nombre es " + name);
        }
        static int sumn(int a, int b)
        {
            return a+b;
        }
    }
}
