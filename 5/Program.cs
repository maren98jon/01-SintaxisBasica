using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta el segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La multiplicación de tus dos numeros es: " + (num1 * num2));
        }
    }
}
