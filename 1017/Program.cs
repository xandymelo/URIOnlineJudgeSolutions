﻿using System;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempoPerdido = int.Parse(Console.ReadLine());
            double kmHora = int.Parse(Console.ReadLine());
            double litrosGastos = (tempoPerdido * kmHora)/12;
            Console.WriteLine($"{litrosGastos:f3}");
        }
    }
}
