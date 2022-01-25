using System;

namespace S06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();
            int largura = palabra.Length;
            string nuevo = palabra.Substring(0, largura / 2).ToUpper();
            palabra = palabra.Replace(palabra.Substring(0, largura / 2), nuevo);
            Console.WriteLine(palabra);
        }
    }
}
