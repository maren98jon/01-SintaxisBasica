using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número de 3 dígitos: ");
            string numString = Console.ReadLine();
            int num1 = Convert.ToInt32(numString.Substring(0, 1));
            int num2 = Convert.ToInt32(numString.Substring(1, 1));
            int num3 = Convert.ToInt32(numString.Substring(2, 1));
            Console.WriteLine("La suma de sus digitos es de: " + (num1 + num2 + num3));

        }
    }
}
