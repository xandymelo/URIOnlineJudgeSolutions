using System;
using System.Collections.Generic;
using static System.Boolean;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
  bool avaliador = true;
  while (avaliador)
  {
    int numero = Convert.ToInt32(Console.ReadLine());
    int soma = 0;
    if (numero == 0)
    {
      avaliador = false;
      break;
    }
    if (numero % 2 == 0)
    {
      IEnumerable<int> sequencia = Enumerable.Range(0, 5);
      foreach (int i in sequencia)
      {
        soma += numero;
        numero += 2;
      }
    }
    else 
    {
      numero += 1;
      IEnumerable<int> sequencia2 = Enumerable.Range(0, 5);
      foreach (int i in sequencia2)
      {
        soma += numero;
        numero += 2;
      }
    }
    Console.WriteLine(soma);
    }
  }
  }


