using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
           Hola(19,18);
          
        }

        //Funcion Hola
        public static int Hola(int num1,int num2){
          if(num1>num2){
              Console.WriteLine("Numero 1 es mayor a Numero 2");
          }
          else 
          {
              if(num1<num2){
                  Console.WriteLine("Numero 2 es mayor a Numero 1");
              }
              else{
                  Console.WriteLine("Son iguales");
              }

          }
           return num1;
 
          
        }
    }
}
