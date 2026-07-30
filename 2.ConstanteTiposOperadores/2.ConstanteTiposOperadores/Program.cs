using System;

namespace _2.ConstanteTiposOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string iva = "19%";
            string nombre = "Dylan";
            nombre = "Enrique";
            //iva = "20%"; una constante no se le puede cambiar su valor

            //Tipos de datos
            byte dato1 = 255;
            int dato2 = -256;
            ulong dato3 = 1626749;
            float dato4 = 5.3f;
            double dato5 = 46872.64582;
            char dato6 = 'g'; //Almacena solo un caracter
            string dato7 = "ufhvsy64euoñdñ{+{"; 
            bool dato8 = false; //true o false
            object dato9 = new object();
            //Operadores
            //Numericos 
            //Cambio de signo 
            int dato10 = 5;
            int dato11 = -dato10;
            int dato12 = +dato11;
            int dato13 = -dato12;
            //Console.WriteLine("dato10: {0}, dato11:{1}, dato12:{2}, dato13:[3}", dato10, dato11, dato12, dato13);
            //Operadores aritmeticos
            int dato14 = 5 + 3;//suma
            int dato15 = dato14 - 2;//resta
            int dato16 = 10 * 3;//producto 
            //float dato17 = 5.0f / 3.0f;//division
            //float dato17 = (float)5 / 3;
            float dato17 = 5f / 3;
            Console.WriteLine("suma:{0}, resta:{1}, producto:{2}, division:{3}", dato14, dato15, dato16, dato17);

            //Incremento - decremento
            int dato18 = 1;
            dato18++;//dato18=dato18+1
            dato18--;//dato18=dato18-1
            dato18 += 3;//dato18=dato18+3
            dato18 -= 2;//dato18=dato18-2
            dato18 *= 5;//dato18=dato18*5
            dato18 /= 3;//dato18=dato18/3

        }
    }
}
