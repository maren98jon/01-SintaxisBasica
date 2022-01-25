using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numero = rnd.Next(1, 105);
            Console.WriteLine("El número generado es: " + numero);
        }
    }
}
