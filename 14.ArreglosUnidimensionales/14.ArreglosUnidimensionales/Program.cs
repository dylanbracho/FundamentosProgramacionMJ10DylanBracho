using System;
using System.Runtime.InteropServices;

namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales - Vectores
            /* int[] numeros = new int[5];
             numeros[0] = 15;
             numeros[1] = 102;
             numeros[2] = 54;
             numeros[3] = 26;
             numeros[4] = 5;
             //numeros[5] = 11; No se puede porque la posicion 6 con indice 5 no existe
             Console.WriteLine($"El numero almacenado en la posicion 4 con indice 3 es: {numeros[3]}");
             //Otras fromas de declarar e inicializar vectores
             char[] simbolos = new char[] {'?','/','o','5'};
             bool[] valoresVerdad = {true, false, true, false, true, true};
             //Recorrer para llenar de datos el vector 
             string[] nombres = new string[7];
             for (int i = 0; i < 7; i++)
             {
                 Console.WriteLine($"Ingrese el nombre para la P{i+1}: I{i}:");
                 nombres[i] = Console.ReadLine();
             }
             Console.Clear();
             //Recorrer para recuperar datos almacenados
             for (int i = 0; i < nombres.Length; i++)
             {
                 Console.Write($" {nombres[i]} |");
             }*/
            //Crear arreglo llamado "enteros" de 100 elementos asignar el numero 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y mostrarlo en pantalla
            /*int[] enteros = new int[100];
            for (int i = 0; i < 100; i++)
            {
                enteros[i] = 10;
            }
            for (int i = 0; i < enteros.Length; i++)
            {
                Console.Write($"Posicion {i+1}: {enteros[i]} |");
            }*/

            //Algoritmo que permita solicitar 10 numeros, los cuales seran almacenados en un arreglo,al final, debe visualizar el promedio de esos numeros.
            /*int[] numeros = new int[10];
            float promedio = 0f;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el numero P{i+1}, I{i}:");
                numeros[i] = int.Parse(Console.ReadLine());
                promedio += numeros[i];
            }
            promedio /= numeros.Length;
            Console.WriteLine($"El promedio de los numeros ingresados es: {promedio}");*/

            //Llene un arreglo con 15 numeros ingresados por tecldo una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo. Finalmente, determine cual es el numero mayor y cual es el numero menor,junto con l aposicion que ocupa cada uno dentro del arreglo.}
            int[] numeros = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el numero P{i + 1}, I{i}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int mayor = numeros[0];
            int menor = numeros[0];
            int posicionMayor = 0;
            int posicionMenor = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posicionMayor = i;
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicionMenor = i;
                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($" {numeros[i]} |");
            }
            
            Console.WriteLine($"\nEl numero mayor es: {mayor}, y su posicion es: {posicionMayor}");
            Console.WriteLine($"El numero menor es: {menor}, y su posicion es: {posicionMenor}");
        }
    }
}
