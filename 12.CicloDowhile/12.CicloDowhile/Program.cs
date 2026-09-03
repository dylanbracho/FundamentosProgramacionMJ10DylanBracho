using System;


namespace _12.CicloDowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algortimo que le pida a un grupo de usuarios su nombre, numero de cuentay saldo; para cada usuario se debe hacer lo siguiente:
            // Si el saldo es mayor o igual a 3,000,000, sacar un mensaje que diga el nombre del usuario, el numero de cuenta, el saldo y "Es apto para credito"
            // Si el saldo es menor a 3,000,000, sacar un mensaje que diga el nombre del usuario, el numero de cuenta, el saldo y "No es apto para credito"
            //El algoritmo debe permitir preguntar la informacion de usuarios, hatsa que se le indique que ya no se desea preguntar mas
            //Ademas , el algoritmo debe permitir mostrar el numero de usuarios a los que se le pregunto por la informacion, y debe mostrar el promedio de los saldos
            /*string nombre; 
            long Ncuenta = 0L;
            float saldo = 0f;
            char continuar = 'Y';
            int contador = 0;
            float acumulador = 0f;
            //float algo = 0f;
            char usuarios = 'N';
            float promedio = 0;

            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su numero de cuenta");
                Ncuenta = long.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo");
                saldo = float.Parse(Console.ReadLine());
                contador++;
                acumulador += saldo;
               

                if (saldo >= 3000000f)
                {
                    Console.WriteLine($"El usuario {nombre}, con el numero de cuenta {Ncuenta} y el saldo {saldo}, Es apto para el credito");
                    
                }
                else
                {
                    Console.WriteLine($"El usuario {nombre}, con el numero de cuenta {Ncuenta} y el saldo {saldo}, No es apto para el credito");
                  
                }

                Console.WriteLine("¿Desea continuar?, Y para si, N para no:");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar == 'Y');
            promedio = acumulador / contador;
            Console.WriteLine("¿Desea ver la cantidad de usuarios por los que se pregunto y el promedio de saldos?, Y para si, N para no");
            usuarios = char.Parse(Console.ReadLine());

            if (usuarios == 'Y')
            {
                Console.WriteLine($"La cantidad de usuarios preguntados es: {contador} y el promedio de saldos es: {promedio}");
            }*/

            //Crear un algoritmo que: permita al usuario ingresar un contraseña, se repita hasta que ingrese la contraseña correcta correcta, mostrar cuantos ingresos realizo
            int contraseña = 0;
            int intentos = 0;

            do
            {
                Console.WriteLine("Ingrese la contraseña");
                contraseña = int.Parse(Console.ReadLine());
                intentos++;

            } while (contraseña != 123);
            Console.WriteLine($"Intentos realizados: {intentos}");
        }
    }
}
