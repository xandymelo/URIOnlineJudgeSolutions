using System;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double media;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            media = (((A*3.5)) + ((B*7.5)))/(3.5+7.5);
            Console.WriteLine($"MEDIA = {(string.Format("{0:0.00000}",media))}");
        }
    }
}
