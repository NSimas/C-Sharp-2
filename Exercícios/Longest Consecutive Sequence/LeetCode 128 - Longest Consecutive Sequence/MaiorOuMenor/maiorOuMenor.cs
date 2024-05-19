using System;

class Program
{
    static void Main(string[] args)
    {
      int saldoTotal = int.Parse(Console.ReadLine());

      int valorSaque = int.Parse(Console.ReadLine());
      
      if (valorSaque <= saldoTotal)
      {
        saldoTotal = saldoTotal - valorSaque;
        Console.WriteLine("Saque realizado com sucesso. Novo saldo: " + saldoTotal);
      }
      else
      {
        Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
      }
    }
}