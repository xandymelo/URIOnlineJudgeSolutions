using System;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaKm = int.Parse(Console.ReadLine());
            double litros = Convert.ToDouble(Console.ReadLine());
            double kmPorLitro = distanciaKm / litros;
            

            Console.WriteLine($"{kmPorLitro:f3} km/l");
            Console.ReadKey();
        }
    }
}
