using System;

namespace S08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una suma: ");
            string suma = Console.ReadLine();
            int posi = suma.IndexOf("+");
            Console.WriteLine("Sus numeros son: " + suma.Substring(0, posi) + " y " + suma.Substring(posi + 1));
        }
    }
}
