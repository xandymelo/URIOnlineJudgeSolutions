using System;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario;
            double vendas;
            double total;
            nome = (Console.ReadLine());
            salario = Convert.ToDouble(Console.ReadLine());
            vendas = Convert.ToDouble(Console.ReadLine());
            total = ((vendas*0.15) + (salario));
            total = Math.Round(total, 2);
            Console.WriteLine($"TOTAL = R$ {total:f2}");
            Console.ReadKey();
        }
    }
}
