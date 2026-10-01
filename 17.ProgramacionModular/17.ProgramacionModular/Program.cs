using System;

namespace _17.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de fundamentos de programacion");
            MostrarMensaje("Dylan");
            MostrarMensaje("Dylan", "Bracho");
            Console.ReadKey();
            borrarPantalla();
        }

        //Procedimientos sin parametros

        static void borrarPantalla()
        {
            Console.Clear();
        }

        //Programacion con parametros

        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de fundamentos de programacion");
        }

        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de Fundamentos de programacion");
        }
    }
}
