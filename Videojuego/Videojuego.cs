using System;

namespace Videojuego
{
    class Program
    {
        static void Main(string[] args)
        {
        string NP1;
        string PA1;
        string PV1;
        string NP2;
        string PA2;
        string PV2;

            Console.WriteLine("Nombre de personaje 1");
            NP1 = Console.ReadLine();
            Console.WriteLine("Puntos de ataque de " + NP1);
            PA1 = Console.ReadLine();
            Console.WriteLine("Vida de "+ NP1);
            PV1 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Nombre de personaje 2");
            NP2 = Console.ReadLine();
            Console.WriteLine("Puntos de ataque de " + NP2);
            PA2 = Console.ReadLine();
            Console.WriteLine("Vida de " + NP2);
            PV2 = Console.ReadLine();

            Console.WriteLine();

            int ataque1 = Int32.Parse(PA1);
            int vida1 = Int32.Parse(PV1);
            int ataque2 = Int32.Parse(PA2);
            int vida2 = Int32.Parse(PV2);

            Console.WriteLine(NP1 + " ataca a " + NP2);
            Console.WriteLine();
            Console.WriteLine("Vida restante de " + NP2);
            Console.WriteLine(vida2-ataque1);
        }
    }
}
