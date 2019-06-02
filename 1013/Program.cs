using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha1 = Console.ReadLine();

            String[] values1 = linha1.Split(' ');
            int a = int.Parse(values1[0]);
            int b = int.Parse(values1[1]);
            int c = int.Parse(values1[2]);
            int MaiorAB = (a+b+Math.Abs(a-b))/2;
            int MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB - c))/2;

            Console.WriteLine($"{MaiorABC} eh o maior");
            Console.ReadKey();
        }
    }
}
