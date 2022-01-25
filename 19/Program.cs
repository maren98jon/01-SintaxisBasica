using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resto = num1 - (num1 / num2) * num2;
            Console.WriteLine(resto);
        }
    }
}
