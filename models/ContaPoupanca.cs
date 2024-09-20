using System;

public class ContaPoupanca : Conta, IDepositavel
{
    public ContaPoupanca (Pessoa titular, int agencia, double taxaSaque) : base(titular, agencia)
    {
        TaxaSaque = taxaSaque;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine("Depósito de {valor:C} realizado. Saldo atual: {Saldo:C}");
    }

    public override Transferir(Conta conta, double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
        }
        else
        {
            Saldo -= valor;
            conta.Saldo += valor;
            Console.WriteLine("Transferência de {valor:C} realizada. Saldo atual: {Saldo:C}");
        }
    }
    
}