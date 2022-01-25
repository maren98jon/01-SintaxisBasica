using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio de tu circulo:");
            int radio = Convert.ToInt32(Console.ReadLine());
            //double radiocuadrado = Math.Pow(radio, 2);
            //double numPI = System.Math.PI;
            //float area = Convert.ToInt32(numPI) * Convert.ToInt32(radiocuadrado);
            Console.WriteLine("El área de tu circulo es de: " + 3.141593*radio*radio + " y el perimetro de tu circulo es de:" + (2 * 3.141593 * radio));

        }
    }
}
