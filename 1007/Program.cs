using System;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;
            int diferenca;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());
            diferenca = (A*B) - (C*D);
            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
