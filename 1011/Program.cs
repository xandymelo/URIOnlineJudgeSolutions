using System;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio = Convert.ToDouble(Console.ReadLine());
            double volume = (4/3.0)*3.14159*(radio*radio*radio);
            Console.WriteLine($"VOLUME = {volume:f3}");
            Console.ReadKey();
        }
    }
}
