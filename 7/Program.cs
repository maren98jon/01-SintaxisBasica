using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta el segundo número:");
            float num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de sumarlos es: " + (num1 + num2));
            Console.WriteLine("El resultado de multiplicarlos es: " + (num1 * num2));
            Console.WriteLine("El resultado de restarlos es: " + (num1 - num2));
            Console.WriteLine("El resultado de dividirlos es: " + num1/num2);
            Console.WriteLine("El resultado del resto de la division es: " + (num1 % num2));
        }
    }
}
