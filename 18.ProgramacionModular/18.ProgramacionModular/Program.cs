using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }
        static float Suma()
        {
            float suma = 0;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Quiere seguir sumando: s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }
        static float Resta()
        {
            float numero2 = 0f;
            float numero1 = 0f;

            Console.WriteLine("Ingrese el numero 1:");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2:");
            numero2 = float.Parse(Console.ReadLine());
            return  numero1 - numero2;
        }
        static float Multiplicacion()
        {
            float multiplicacion = 1;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Quiere seguir multiplicando: s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicacion;
        }
        static float Division()
        {
            float numero2 = 0f;
            float numero1 = 0f;

            Console.WriteLine("Ingrese el numero 1:");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2:");
            numero2 = float.Parse(Console.ReadLine());
            return numero1 / numero2;
        }
        static void RealizarOperaciones(int opcion)
        {
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"la suma de los numeros ingresados es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"la resta de los numeros ingresados es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"la multiplicacion de los numeros ingresados es {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"la division de los numeros ingresados es {Division()}");
                        break;
                    
                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();
            }
            
        }
        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }
        static void MostrarMenu()
        {
            Console.WriteLine("--------------Menu---------------");
            Console.WriteLine("1. Suma              2.Resta");
            Console.WriteLine("3. Multiplicacion    4.Division");
            Console.WriteLine("0. Salir");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ingrese una opcion del menu:");
        }
    }
}
