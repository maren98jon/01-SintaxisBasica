using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca unos segundos:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int horas = numero / 3600;
            int minutos = (numero % 3600) / 60;
            int segundos = minutos % 60;
            Console.WriteLine("Tus " + numero + " segundos son: " + horas + " horas " + minutos + " minutos " + segundos + " segundos");
        }
    }
}
