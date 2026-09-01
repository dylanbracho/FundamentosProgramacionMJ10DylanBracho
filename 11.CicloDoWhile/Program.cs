using System;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo Do While
            /* int contador = 1;
             int contador = 0;

             do
             {
                 contador += contador;
                 contador ++;
             } while (contador <= 5);

             Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {contador}");*/

            // Algoritmo que solicita un numero y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y asi sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar

            /*int contador = 1;
            int numero = 0;
            bool continuar = true;
            
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine($"{numero}x{contador}={numero * contador}");
                    contador ++;
                } while (contador <= 10);
                contador = 1;
                Console.WriteLine("¿Desea continuar? true para si, false para no: ");
                continuar = bool.Parse(Console.ReadLine());

            } while (continuar == true);*/
           
            //Crear un algoritmo que permita calcular y mostrar por pantalla los numeros primos hasta el numero 100
            int contador = 1;
            int numero = 1;

            do
            {
                if (contador % numero == contador && contador%contador == 1 ) 
                {
                  Console.WriteLine(contador);
                }
                
            } while (true);
        }
    }
}
