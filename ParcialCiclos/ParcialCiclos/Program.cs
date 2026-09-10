using System;

namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float promedio = 0f;
            int contador = 1;
            int edad4 = 0;
            int edad5 = 0;
            int edad6 = 0;
            do
            {
                
                Console.WriteLine("Ingrese la edad del estudiante: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad == 4 || edad == 5 || edad == 6)
                {
                    promedio += edad;
                    contador ++;

                    switch (edad)
                    {
                        case 4:
                            edad4++;
                        break;

                        case 5:
                            edad5++;
                        break;

                        case 6:
                            edad6++;
                        break;
                    
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una edad valida");
                }

            } while (contador <= 15);

            promedio /= 15f;

            if (edad6 > edad5 && edad6 > edad4)
            {
                Console.WriteLine("Grupo Mayor");
            }
            else if (edad4 > edad5 && edad4 > edad6)
            {
                Console.WriteLine("Grupo Menor");
            }
            else
            {
                Console.WriteLine("Grupo Equilibrado");
            }

            Console.WriteLine($"El promedio de edades de los estudiantes es {promedio}, y la cantidad de estudiantes de cada edad es: 4:{edad4}, 5:{edad5}, 6:{edad6}");

        }
    }
}
