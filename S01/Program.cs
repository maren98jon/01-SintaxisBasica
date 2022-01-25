using System;

namespace S01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase:");
            string frase = Console.ReadLine();
            int largura = frase.Length;
            Console.WriteLine("Su frase es de: " + largura + " carácteres de largo.");
        }
    }
}
