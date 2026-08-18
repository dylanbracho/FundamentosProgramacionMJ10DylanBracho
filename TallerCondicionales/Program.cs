using System;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Ejercicio 1
            /*int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            Console.WriteLine("Ingrese numero 1");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero 2");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 3");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero1!=numero3 && numero2!=numero3)
            {
                    if (numero1 > numero2)
                    {
                        if (numero1 > numero3)
                        {
                            Console.WriteLine("el numero 1 es el mayor");
                            if (numero2 > numero3)
                            {
                                Console.WriteLine($"Mayor:{numero1}, medio:{numero2}, menor:{numero3}");
                            }
                            else
                            {
                                Console.WriteLine($"Mayor:{numero1}, medio:{numero3}, menor:{numero2}");
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("el numero 3 es el mayor");
                            Console.WriteLine($"Mayor:{numero3}, medio:{numero1}, menor:{numero2}");
                        }
                    }
                    else
                    {
                        if (numero2 > numero3)
                        {
                            Console.WriteLine("el numero 2 es el mayor");
                            if (numero1 > numero3)
                            {
                                Console.WriteLine($"Mayor:{numero2}, medio:{numero1}, menor:{numero3}");
                            }
                            else
                            {
                                Console.WriteLine($"Mayor:{numero2}, medio:{numero3}, menor:{numero1}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("el numero 3 es el mayor");
                            Console.WriteLine($"Mayor:{numero3}, medio:{numero2}, menor:{numero1}");
                        }
                    }
            }*/
            //---------------------------------------------------------------------------------------
            bool invencible = false;
            int municion = 0;
            Console.WriteLine("¿El personaje es invencible?");
            invencible = bool.Parse(Console.ReadLine());
            Random rnd = new Random();
            municion = rnd.Next(1,20);
            Console.WriteLine("Municion = " + municion);

        }
    }
}
