using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que le pida al usuario ingresar por teclado numeros enteros al azar. al usuario le corresponde ingresar la cantidad de numeros que va a introducir
            /* debe escribir la cantidad de 0, mayores a 0 y menores a 0 */
           
          /*  int cantidad = 0;
            int numeros = 0;
            int contador = 0;
            int contadorPos = 0;
            int contadorNeg = 0;
            int contador0 = 0;

            Console.WriteLine("Ingrese la cantidad de numeros a evaluar");
            cantidad = int.Parse(Console.ReadLine());

            while (contador < cantidad)
            {
                contador++;
                Console.WriteLine("Ingrese el numero a evaluar");
                numeros = int.Parse(Console.ReadLine());

                if ( numeros > 0 )
                {
                    contadorPos++;
                }
                else
                {
                    if ( numeros < 0 )
                    {
                        contadorNeg++;
                    }
                    else
                    {
                        contador0++;
                    }
                }
            }

            Console.WriteLine($"La cantidad de numeros positivos es:{contadorPos}");
            Console.WriteLine($"La cantidad de numeros negativos es:{contadorNeg}");
            Console.WriteLine($"La cantidad de ceros es:{contador0}");*/

            int rango = 0;
            int contador = 1;
            int contadorPar = 0; 
            int cantidad = 0;

            Console.WriteLine("Ingrese el rango de numero que quiere evaluar:");
            rango = int.Parse(Console.ReadLine());

            while ( contador <= rango )
            {

                if ( contador % 2 == 0)
                {
                    contadorPar++;
                    Console.WriteLine($"{contador} - ");
                }
                contador++;
            }

            Console.WriteLine($"La cantidad de numeros par es:{contadorPar}");
        }
    }
}
