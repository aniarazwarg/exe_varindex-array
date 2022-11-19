using System;

class Program {
  public static void Main (string[] args) {
  int[] numero = new int[10];
  for(int i=0; i<10; i++)
  {
    Console.Write("digite o {0}º valor: ",i+1);
    numero[i] = int.Parse(Console.ReadLine());
  }
  for(int i=0; i<10; i++) 
  {
    Console.WriteLine("O {0}º valor digitado: {1}",i+1,numero[i]);
  }
  }
}