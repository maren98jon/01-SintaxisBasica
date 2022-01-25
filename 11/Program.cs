using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer numero:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero:");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer numero:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            float suma = num1 + num2 + num3;
            float media = suma / 3;
            Console.WriteLine("La media de tus 3 numeros es: " + media);
            
            {

            }

        }
    }
}
