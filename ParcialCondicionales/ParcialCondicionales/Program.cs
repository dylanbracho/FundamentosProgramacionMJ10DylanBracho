using System;
using System.Diagnostics.Eventing.Reader;
using System.Threading;
using System.Xml.Serialization;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mesnacimiento = "nada";
            string signo = "nada";
            Console.WriteLine("Ingrese su mes de nacimiento");
            mesnacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese su signo zodiacal");
            signo = Console.ReadLine();

            switch (signo)
            {
                case "Aries" :
                    if (mesnacimiento == "Marzo" || mesnacimiento == "Abril")
                    {
                        Console.WriteLine("El elemento de la persona es Fuego");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Leo":
                    if (mesnacimiento == "Julio" || mesnacimiento == "Agosto")
                    {
                        Console.WriteLine("El elemento de la persona es Fuego");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Sagitario":
                    if (mesnacimiento == "Noviembre" || mesnacimiento == "Diciembre")
                    {
                        Console.WriteLine("El elemento de la persona es Fuego");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Tauro":
                    if (mesnacimiento == "Abril" || mesnacimiento == "Mayo")
                    {
                        Console.WriteLine("El elemento de la persona es Tierra");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Virgo":
                    if (mesnacimiento == "Agosto" || mesnacimiento == "Septiembre")
                    {
                        Console.WriteLine("El elemento de la persona es Tierra");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Capricornio":
                    if (mesnacimiento == "Diciembre" || mesnacimiento == "Enero")
                    {
                        Console.WriteLine("El elemento de la persona es Tierra");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Géminis":
                    if (mesnacimiento == "Mayo" || mesnacimiento == "Junio")
                    {
                        Console.WriteLine("El elemento de la persona es Aire");
                    }
                    break;
                case "Libra":
                    if (mesnacimiento == "Septiembre" || mesnacimiento == "Octubre")
                    {
                        Console.WriteLine("El elemento de la persona es Aire");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Acuario":
                    if (mesnacimiento == "Enero" || mesnacimiento == "Febrero")
                    {
                        Console.WriteLine("El elemento de la persona es Aire");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Cáncer":
                    if (mesnacimiento == "Junio" || mesnacimiento == "Julio")
                    {
                        Console.WriteLine("El elemento de la persona es Agua");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Escorpio":
                    if (mesnacimiento == "Octubre" || mesnacimiento == "Noviembre")
                    {
                        Console.WriteLine("El elemento de la persona es Agua");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                case "Piscis":
                    if (mesnacimiento == "Marzo" || mesnacimiento == "Febrero")
                    {
                        Console.WriteLine("El elemento de la persona es Agua");
                    }
                    else
                    {
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    }
                    break;
                default:
                    Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                    break; 
            }
        }  
    }
}
