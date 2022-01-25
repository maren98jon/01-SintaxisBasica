using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce la distancia (en metros): ");
            int dist = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el tiempo--> Horas: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minutos: ");
            int minutos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());
            float SegTot = horas * 3600 + minutos * 60 + segundos;
            float MetxSeg = dist / SegTot;
            Console.WriteLine("Tu velocidad es de: " + MetxSeg + " metros/segundo o de: " + MetxSeg * 3.6 + " en kilometros / hora.");
        }
    }
}
