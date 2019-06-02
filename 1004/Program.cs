using System;

namespace _1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int PROD;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            PROD = A * B;
            Console.WriteLine($"PROD = {PROD}");
        }
    }
}
