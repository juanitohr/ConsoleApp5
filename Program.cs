using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 5;
            int num2 = 6;
            double num3 = 2.57;
            double suma;
            suma = num1 + num3;

            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("El numero introduciodo es: " + valor1);
            int valorint = Convert.ToInt32(valor1);


            Console.ReadKey();

        }
    }
}
