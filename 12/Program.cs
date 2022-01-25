using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu temperatura en Celsius:");
            float temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu temperatura es de " + ((temp * 9 / 5)+32) + " grados en Fahrenheit.");
        }
    }
}
