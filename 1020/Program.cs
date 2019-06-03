using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias = Convert.ToInt32(Console.ReadLine());
            int ano = dias / 365;
            dias = dias - (ano * 365);
            int mes = dias / 30;
            dias = dias - (mes * 30);
            Console.WriteLine("{0} ano(s)",ano);
            Console.WriteLine("{0} mes(es)",mes);
            Console.WriteLine("{0} dia(s)",dias);
        }
    }
}
