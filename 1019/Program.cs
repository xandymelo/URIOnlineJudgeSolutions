using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = Convert.ToInt32(Console.ReadLine());
            int h = sec /3600;
            sec = sec - (h * 3600);
            int m = sec/60;
            sec = sec - (m * 60);
            Console.WriteLine("{0}:{1}:{2}",h,m,sec);

            Console.ReadKey();
        }
    }
}
