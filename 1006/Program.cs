using System;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            double media;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());
            media = ((A*2) + (B*3) + (C*5))/(2+3+5);
            Console.WriteLine($"MEDIA = {(string.Format("{0:0.0}",media))}");
        }
    }
}
