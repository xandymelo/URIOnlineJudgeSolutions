﻿using System;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {10000, 5000, 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1};
            int res, qtd;
            double entrada = double.Parse(Console.ReadLine());
            string tipo = " nota(s)";
            res = Convert.ToInt32(entrada*100);
            
            Console.WriteLine("NOTAS:");
            for (int i=0; i <12; i++) {
                if (i==6){
                    tipo = " moeda(s)";
                    Console.WriteLine("MOEDAS:");
                }
                //Console.WriteLine(array[i]);
                qtd = res/array[i];
                //usar x %= y é equivalente a x = x % y
                res %=array[i];
                Console.WriteLine(qtd + tipo + " de R$ " + (array[i]/100.0).ToString(("#0.00")));
            }
        }
    }
}
