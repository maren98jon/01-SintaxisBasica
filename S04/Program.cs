using System;

namespace S04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase: ");
            string frase = Console.ReadLine();
            string subcadena = frase.Substring(4,5);
            Console.WriteLine(subcadena);

        }
    }
}
