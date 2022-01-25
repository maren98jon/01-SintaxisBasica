using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int mult = num * i;
                Console.WriteLine(num + " x " + i + " = " + mult);
            }

        }
    }
}
