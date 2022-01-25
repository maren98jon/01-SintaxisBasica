using System;

namespace S07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase: ");
            string frase = Console.ReadLine();
            string subcadena = frase.Substring(4,6);
            Console.WriteLine(subcadena);
        }
    }
}
