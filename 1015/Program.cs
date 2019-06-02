using System;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha1 = Console.ReadLine();
            string linha2 = Console.ReadLine();

            String[] values1 = linha1.Split(' ');
            double x1 = Convert.ToDouble(values1[0]);
            double y1 = Convert.ToDouble(values1[1]);

            String[] values2 = linha2.Split(' ');
            double x2 = Convert.ToDouble(values2[0]);
            double y2 = Convert.ToDouble(values2[1]);
            
            double distancia = Math.Sqrt((Math.Pow(x2 - x1,2)) + (Math.Pow(y2-y1,2)));
            Console.WriteLine($"{distancia:f4}");
            Console.ReadKey();
        }
    }
}
