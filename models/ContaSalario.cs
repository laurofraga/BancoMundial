using System;

public class ContaSalario : ContaSalario 
{
    public ContaSalario(Pessoa titular, int agencia) : base(titular, agencia)
    {
    }

    public override void Transferir(Conta conta, double valor)
    {
       if (Titular == conta.Titular && Saldo >= valor)
       {
              Saldo -= valor;
              conta.Saldo += valor;
              Console.WriteLine("Transferência de {valor:C} realizada. Saldo atual: {Saldo:C}");
         }
         else
         {
              Console.WriteLine("Transferência não realizada. Saldo insuficiente.");
       }
    }
}