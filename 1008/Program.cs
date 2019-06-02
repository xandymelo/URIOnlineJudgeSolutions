using System;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int horas;
            double valorHora;
            double salario;
            numero = Convert.ToInt32(Console.ReadLine());
            horas = Convert.ToInt32(Console.ReadLine());
            valorHora = Convert.ToDouble(Console.ReadLine());
            salario = horas * valorHora;
            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {String.Format("{0:0.00}",salario)}");
        }
    }
}
