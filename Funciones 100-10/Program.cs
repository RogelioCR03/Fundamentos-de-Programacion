using System;

namespace Funciones_100_10
{
    class Program
    {
        static void Main(string[] args)
        {
            restar();
        }

        public static void restar(){
            int i;
            for(i=100; i>=0; i-=10){
                Console.WriteLine(i);
            }
        }
    }
}
