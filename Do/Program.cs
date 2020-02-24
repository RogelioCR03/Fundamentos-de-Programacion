using System;

namespace Do
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciclos con Do");
            int C=0;
            string tecla;
            
            do 
            {
                Console.WriteLine("Menú");
                Console.WriteLine("A) Dar de alta");
                Console.WriteLine("B) Dar de baja");
                Console.WriteLine("C) Consultar");
                Console.WriteLine("S) Salir");

                tecla=Console.ReadLine();


                if(tecla=="a"||tecla=="A"){
                    Console.WriteLine("Estas en el menu: Dar de alta");
                }
                if(tecla=="b"||tecla=="B"){
                    Console.WriteLine("Estas en el menu: Dar de baja");
                }
                if(tecla=="c"||tecla=="C"){
                    Console.WriteLine("Estas en el menu: Consultar");
                }
                if(tecla=="s"||tecla=="S"){
                    C=1;
                }
            } while(C==0);
        }
    }
}
