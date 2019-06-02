using System;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 0;
            double A = 0;
            R = Convert.ToDouble(Console.ReadLine());
            A = 3.14159 * (R*R);
            Console.WriteLine("A="+String.Format("{0:0.0000}", A));
            Console.ReadKey();
        }
    }
}
