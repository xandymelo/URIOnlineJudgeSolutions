using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine(valor);
            int[] valores = new int[] {100, 50, 20, 10, 5, 2, 1}; 
            int[] cedulas = new int[7];
            for(int i = 0; i < valores.Length; i++){
                if ((valor / valores[i]) > 0){ 
                    cedulas[i] = (valor / valores[i]); 
                    valor = valor % valores[i]; 
                }else{ 
                    cedulas[i] = 0;
                } 
            } 
            for(int i = 0; i < valores.Length; i++){ 
                Console.WriteLine(String.Format("{0} nota(s) de R$ {1},00", cedulas[i], (double.Parse(valores[i].ToString())))); 
            }
            Console.ReadKey();
        }
    }
}
