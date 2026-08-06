using System;

namespace _4.CondicionalesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*Estructuras de control condicional
            //Condicional simple

            //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web".
            /* byte edad = 0;
              Console.WriteLine("Ingrese su edad:");
              edad = Convert.ToByte(Console.ReadLine());

              if (edad >= 18)
              {
                  //si la condicion es verdadera
                  Console.WriteLine("Bienvenido a mi sitio web");
              }*/

            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mesaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos
            /*    float sueldo = 0; 
                  string nombre = null;
                  Console.WriteLine("Ingrese su nombre");
                  nombre = Console.ReadLine();
                  Console.WriteLine("Ingrese su sueldo");
                  sueldo = Convert.ToSingle(Console.ReadLine());

                  if (sueldo >= 3000)
                  {
                      Console.WriteLine( nombre + " debe abonar impuestos");
                  }*/

            //Crea un algortimo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostar el siguiente mensaje: "Bienvenido a mi sitio web". de lo contrario, mostrar el mensaje "No es apto para el contenido de este sitio web".
            /* byte edad = 0;
             Console.WriteLine("Ingrese su edad:");
             edad = Convert.ToByte(Console.ReadLine());

             if (edad >= 18)
             {
                 //si la condicion es verdadera
                 Console.WriteLine("Bienvenido a mi sitio web");
             }
             else
             {
                 //Si la condicion NO se cumple
                 Console.WriteLine("No es apto para el contenido de este sitio web");
             }*/

            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mesaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. de lo contrario mostrar el mensaje "Persona exenta de impuestos"
            /*float sueldo = 0;
            string nombre = null;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo >= 3000)
            {
                Console.WriteLine(nombre + " debe abonar impuestos");
            }
            else
            {
                Console.WriteLine("Persona exenta de impuestos");
            }*/

            //Crear un algoritmo que permita ingresar dos numeros, si el el primer numero es mayor al segundo numero informar su suma y diferencia, en caso contrario informar el proucto y la division del primer numero respecto al segundo numero
            byte numero1 = 0;
            byte numero2 = 0;
            Console.WriteLine("ingrese primer numero");
            numero1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("ingrese segundo numero");
            numero2 = Convert.ToByte(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("Esta es su suma" + numero1 + numero2);
                Console.WriteLine("Esta es su resta" + numero1 - numero2);
            }
            else
            {
                Console.WriteLine("Esta es su producto" + numero1 * numero2);
                Console.WriteLine("Esta es su division" + numero1 / numero2);
            }

        }
    }
}
