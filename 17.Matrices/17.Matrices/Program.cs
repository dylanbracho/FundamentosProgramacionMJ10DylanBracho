using System;

namespace _17.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñe un algoritmo que permita transformar una matriz numérica reemplazando todos sus elementos que sean menores a un valor umbral N, por dicho valor.
            Console.WriteLine("Ingrese el numero de columnas:");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de filas:");
            int filas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[col , filas];

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.WriteLine($"Ingrese el valor de la P{i},{j}:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese el valor limite:");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] < N)
                    {
                        matriz[i, j] = N;
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i,j]} |");
                }
            }
         
            
        }
    }
}
