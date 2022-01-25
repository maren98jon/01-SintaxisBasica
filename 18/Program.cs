using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un dígito: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int suma = num + (num * 10 + num) + (num * 100 + num * 10 + num);
            Console.WriteLine("La suma de n + nn + nnn es: " + suma);
        }
    }
}
