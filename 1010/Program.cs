using System;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha1 = Console.ReadLine();
            string linha2 = Console.ReadLine();

            String[] values1 = linha1.Split(' ');
            int codigo1 = Int32.Parse(values1[0]);
            int qtde1 = Int32.Parse(values1[1]);
            double valor1 = Convert.ToDouble(values1[2]);

            String[] values2 = linha2.Split(' ');
            int codigo2 = Int32.Parse(values2[0]);
            int qtde2 = Int32.Parse(values2[1]);
            double valor2 = Convert.ToDouble(values2[2]);
            
            double total = (qtde1 * valor1) + (qtde2 * valor2);
            Console.WriteLine($"VALOR A PAGAR: R$ {total:f2}");
        }
    }
}
