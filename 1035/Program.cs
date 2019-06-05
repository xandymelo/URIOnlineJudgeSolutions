using System;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            String[] valores = linha.Split(' ');
            int A = Int32.Parse(valores[0]);
            int B = Int32.Parse(valores[1]);
            int C = Int32.Parse(valores[2]);
            int D = Int32.Parse(valores[3]);
            if ((B > C) && (D > A) && ((C+D)>(A+B)) && (C > 0) && (D > 0) && (A % 2 == 0)){
                Console.WriteLine("Valores aceitos");
            }else{
                Console.WriteLine("Valores nao aceitos");    
            }               
            
        }
    }
}
