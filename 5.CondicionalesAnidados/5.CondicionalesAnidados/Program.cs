using System;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales anidados
            //Dsieñar un algoritmo que lea tres numeros A,B,C y visualice el valor mas grande. El usuario debe ingresar tres valores diferentes.
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("se debe ingresar tres valores diferentes");
            Console.WriteLine("Ingrese el valor del primer numero");
            num1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo numero");
            num2 = int.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tercer numero");
            num3 = int.Parse (Console.ReadLine());

            if (num1 > num2)
            {
                //Verdadero
                if (num1 > num3)
                {
                    Console.WriteLine("El primer numero es el mayor");
                }
                else
                {
                    Console.WriteLine("El tercer numero es el mayor");
                }
            }
            else
            {
                //Falso
                if (num2 > num3)
                {
                    Console.WriteLine("El segundo numero es el mayor");
                }
                else
                {
                    Console.WriteLine("El tercer numero es el mayor");
                }

            }

        }
    }
}
