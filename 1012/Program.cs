using System;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha1 = Console.ReadLine();

            String[] values1 = linha1.Split(' ');
            double A = Convert.ToDouble(values1[0]);
            double B = Convert.ToDouble(values1[1]);
            double C = Convert.ToDouble(values1[2]);
            double areaTriangulo = (A * C)/2;
            double areaCirculo = 3.14159 * (C*C);
            double areaTrapezio = ((A+B)*C)/2;
            double areaQuadrado = (B*B);
            double areaRetangulo = A* B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo:f3}");
            Console.WriteLine($"CIRCULO: {areaCirculo:f3}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:f3}");
            Console.WriteLine($"QUADRADO: {areaQuadrado:f3}");
            Console.WriteLine($"RETANGULO: {areaRetangulo:f3}");
        }
    }
}
