using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero de minutos:");
            int minutos = Convert.ToInt32(Console.ReadLine());
            int anyos = minutos / 525600;
            int dias = (minutos % 525600) / (60 * 24);
            Console.WriteLine("Sus minutos son: " + anyos + " años   y " + dias + " dias");//sdfsfdwv
        }
    }
}
