using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor:");
            string a = Console.ReadLine();
            Console.WriteLine("Introduce un valor:");
            string b = Console.ReadLine();
            string c = a;
            a = b;
            b = c;
            Console.WriteLine(a + " " + b);

        }
    }
}
