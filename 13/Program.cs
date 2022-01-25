using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca sus pulgadas:");
            float pulgadas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sus " + pulgadas + " son :" + pulgadas * 0.0254 + " metros.");
        }
    }
}
