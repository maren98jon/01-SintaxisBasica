using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la altura de tu rectángulo:");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la anchura de tu rectángulo:");
            int anchura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El área de tu rectángulo es de: " + (altura * anchura) + " y el perímetro es de: " + (2 * altura + 2 * anchura));
        }
    }
}
