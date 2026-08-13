using System;

namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consicionales multiples
            //crear un algoritmo que muestre por pantalla un menu con 5 opciones, y segun la opcion elegida del menu, muestre un mensaje por pantalla donde se muestre la opcion elegida,en caso de que se seleccione una opcion que no esta en el menu mostrar un mensajede error.
            int respuesta = 0;
            Console.WriteLine(" ----------Menu----------");
            Console.WriteLine(" 1. Opcion 1     2. Opcion 2");
            Console.WriteLine(" 3. Opcion 3     4. Opcion 4");
            Console.WriteLine(" 5. Opcion 5");
            Console.WriteLine("-------------------------");
            Console.Write("Elija una opcion del menu: ");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligio la opcion 1");
                    break;
                case 2:
                    Console.WriteLine("Eligio la opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Eligio la opcion 3");
                    break;
                case 4:
                    Console.WriteLine("Eligio la opcion 4");
                    break;
                case 5:
                    Console.WriteLine("Eligio la opcion 5");
                    break;
                default:
                    Console.WriteLine("Elija una opcion valida");
                    break;


            }
        }
    }
}
