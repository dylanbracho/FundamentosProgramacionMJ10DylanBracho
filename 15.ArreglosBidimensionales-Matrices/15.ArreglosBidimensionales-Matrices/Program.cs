using System;

namespace _15.ArreglosBidimensionales_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales o matrices
            /*int[,] numeros = new int[2,3];
            //numeros[2, 1] = 10; no se puede almacenar porque el indice de la fila no existe
            //numeros[1, 3] = 15; no se puede almacenar porque el indice de la fila no existe
            numeros[0, 0] = 12;
            numeros[0, 1] = 100;
            numeros[0, 2] = 56;
            numeros[1, 0] = 45;
            numeros[1, 1] = 8;
            numeros[1, 2] = 10;
*/
            /* Console.WriteLine($"El valor almacenado en numeros[1,0]:{numeros[1,0]}");*/
            //Recorramos la matriz para llenar
            /*char[,] simbolos = new char[3,2];
            for (int i = 0; i < 3; i++)//Recorre las filas
            {
                for (int j = 0; j < 2; j++)//Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el caracter para simbolos[{i},{j}]:");
                    simbolos[i,j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer para recuperar datos
            Console.Clear();
            for (int i = 0; i < simbolos.GetLength(0); i++) //GetLegth(0) devuelve el numero de filas
            {
                for (int j = 0; j < simbolos.GetLength(1); j++)//GetLegth(1) devuelve el numero de columnas
                {
                    Console.Write($"{simbolos[i,j]} |");
                }
                Console.WriteLine();
            }

            //Otra forma de declarar e inicializar matrices en c#
            string[,] nombres = {
                                    {"Ana","Juan","Carlos","Alvaro"},
                                    {"Pedro", "Ferney", "Yuli", "Felix"},
                                    {"Carla", "Alex", "Esteban", "Salome"}
                                };*/

            //Crear una matriz[10,20], en cada posicion de la matriz poner el numero 100;mostrar la matriz en consola
            /*int[,] cien = new int[10,20];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    cien[i, j] = 100;
                }
            }

            for (int i = 0; i < cien.GetLength(0); i++)
            {
                for (int j = 0; j < cien.GetLength(1); j++)
                {
                    Console.Write($"{cien[i, j]} |");
                }
                Console.WriteLine();
            }
*/
            //Escribe un Programa que realice la suyma de dos matrices de dimensiones 2x3
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] matrizSuma = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el caracter para matriz 1[{i},{j}]:");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el caracter para matriz 2[{i},{j}]:");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizSuma[i, j] += matriz2[i, j];
                    matrizSuma[i, j] += matriz1[i, j];
                }
            }
            Console.Clear();
            for (int i = 0; i < matrizSuma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++)
                {
                    Console.Write($"{matrizSuma[i, j]} |");
                }
                Console.WriteLine();
            }
        }
    }
}
